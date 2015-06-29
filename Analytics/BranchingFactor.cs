using System.Collections.Generic;
using System;
namespace Analytics{
	public class BranchingFactor{
		private static BranchingFactor instance;
		public static BranchingFactor Instance
   		{
	  		get 
	  		{
		         if (instance == null)
		         {
		            instance = new BranchingFactor();
		         }
		         return instance;
		     }
		}
		Dictionary<int,List<Tuple<int,string,string>>> counter = new Dictionary<int,List<Tuple<int,string,string>>>();
		public BranchingFactor(){
			
		}
		public void AddCount(int numChoices, int playerNum){
			if (counter.ContainsKey(playerNum)){
				counter[playerNum].Add(new Tuple<int,string,string>(numChoices,TimeStep.Instance.GetTreeLoc(),TimeStep.Instance.GetTimeStep()));
			}
			else{
				counter[playerNum] = new List<Tuple<int,string,string>>{
					new Tuple<int,string,string>(numChoices,TimeStep.Instance.GetTreeLoc(),TimeStep.Instance.GetTimeStep())
				};
			}
		}
		public override string ToString(){
			string ret = "";
			foreach (var key in counter.Keys){
				ret += "Player " + (key + 1) + "\n";
				foreach (var choices in counter[key]){
					ret += choices + "\n";
				}
			}
			return ret;
		}
	}
	
}