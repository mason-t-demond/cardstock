﻿﻿using System;
using System.Collections.Generic;
using CardEngine;
using FreezeFrame;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Players
{
	public class GeneralPlayer
	{
        protected GameIterator gameContext;
        protected int numPlayers;

        protected List<double> leadList = new List<double>();

        public GeneralPlayer(GameIterator m)
        {
            gameContext = m;
            numPlayers = gameContext.game.players.Count;
        }

        public virtual int MakeAction(List<GameActionCollection> possibles,Random rand){
			return rand.Next(0,possibles.Count);
		}

		public virtual int MakeAction(JObject possibles, Random rand){
			var items = (JArray)possibles ["items"];
			return rand.Next (0,items.Count);
		}

        public static Tuple<int, int> MinMaxIdx(double[] input)
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            int minIdx = -1;
            int maxIdx = -1;
            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i] > max)
                {
                    max = input[i];
                    maxIdx = i;
                }
                if (input[i] < min)
                {
                    min = input[i];
                    minIdx = i;
                }
            }
            return new Tuple<int, int>(minIdx, maxIdx);
        }

        // CODE FOR UPDATING STATISTICS FOR HEURISTICS
        public void RecordHeuristics(double[] inverseRankSum)
        {
            if (gameContext.gameWorld != null)
            {
                // WHAT DOES WRS stand for?
                double[] wrs = new double[inverseRankSum.Length];

                for (int item = 0; item < inverseRankSum.Length; ++item)
                {
                    wrs[item] = (inverseRankSum[item] * ((double)numPlayers / (numPlayers - 1))) -
                                                        ((double)1 / ((numPlayers - 1)));
                }

                var tup = MinMaxIdx(inverseRankSum);
                var max = wrs[tup.Item2];
                var min = wrs[tup.Item1];

                double avg = 0;
                for (int i = 0; i < wrs.Length; i++)
                {
                    avg += wrs[i];
                }
                avg /= (double)wrs.Length;

                var variance = Math.Abs(max - min);

                gameContext.gameWorld.AddInfo(variance, avg, wrs[tup.Item2]);
                leadList.Add(max);
            }
        }

        public virtual List<double> GetLead()
        {
            return leadList;
        }
	}
}

