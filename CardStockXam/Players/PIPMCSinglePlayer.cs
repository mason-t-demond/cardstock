﻿﻿﻿﻿﻿using System;
using System.Collections.Generic;
using CardEngine;
using System.Diagnostics;
using FreezeFrame;
using System.Threading.Tasks;
using CardStockXam.Scoring;

namespace Players
{
    public class PIPMCSinglePlayer : AIPlayer
    {
        private static int NUMTESTS = 10; //previously 20

        public PIPMCSinglePlayer(Perspective perspective) : base(perspective) { }
		

        public override int MakeAction(int numChoices)
        {
            // SetupPrivateGame sets "privategame" equal to actualgame.clonesecret(idx) and
            // sets "privateiterator" equal to actualgameiterator.clone()
            (CardGame privategame, GameIterator privateiterator) = perspective.GetPrivateGame();
            int idx = perspective.GetIdx();

            Debug.WriteLine("PIPMC making choice. items: " + numChoices);

            var inverseRankSum = new double[numChoices];

            Debug.WriteLine("Start Monte");

            // can parallellize here TODO ?
            // FOR EACH POSSIBLE MOVE
           

            for (int move = 0; move < numChoices; ++move)
            {
                Debug.WriteLine("iterating over item: " + move);

                inverseRankSum[move] = 0;

                Parallel.For(0, NUMTESTS, i =>   //number of tests for certain decision
                {
                    Debug.WriteLine("****Made Switch**** : " + i);

                    // JUST USING ONE CLONE SECRETGAME, CLONED FOR EACH MOVE
                    CardGame cg = privategame.Clone();
                    GameIterator cloneContext = privateiterator.Clone(cg);

                    // Make the chosen move
                    List<GameActionCollection> allOptions = cloneContext.BuildOptions();
                    allOptions[move].ExecuteAll();
                    cloneContext.PopCurrentNode();

                    // Assign the AI players for rollout game
                    for (int j = 0; j < numPlayers; j++)
                    {
                        cg.players[j].decision = new RandomPlayer(perspective);
                    }

                    Debug.WriteLine("Playing a simulated game");

                    while (!cloneContext.AdvanceToChoice())
                    {
                        cloneContext.ProcessChoice();
                    }

                    Debug.WriteLine("Simulated Game is Over");

                    // ProcessScore returns a sorted list 
                    // where the winner is rank 0 for either min/max games.
                    var winners = cloneContext.ProcessScore();

                    Debug.WriteLine("past ProcessScore");

                    // TODO record everyone's ranks at all potential moves 
                    // so can give to scoretracker ??
                    for (int j = 0; j < numPlayers; ++j)
                    {
                        // if player is me
                        if (winners[j].Item2 == idx)
                        {

                            // add your rank to the results of this choice
                            lock (this)
                            {
                                inverseRankSum[move] += (((double)1) / (j + 1)) / NUMTESTS;
                            }

                            break;
                        }
                    }

                    Debug.WriteLine("saved the inverseRankSum");
                });
            }

			Debug.WriteLine("End Monte");

            // FIND BEST (and worst) MOVE TO MAKE
            (var minidx, var maxidx) = MinMaxIdx(inverseRankSum);

            Debug.WriteLine("Max invRankSum: " + maxidx);
            Debug.WriteLine("PIPMC Finished.");

            // Record info for heuristic evaluation
            RecordHeuristics(inverseRankSum);

            return maxidx;
        }
    }
}