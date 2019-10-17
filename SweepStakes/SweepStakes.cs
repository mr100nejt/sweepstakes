using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakes
    {
       
        public string sweepStakesName; 
        public SweepStakes(string Name)
        {
            sweepStakesName = Name; 
        }
        UserInterface UI = new UserInterface();
        Dictonary Dictonary = new Dictonary();
        public List<Contestant> contestantList = new List<Contestant>();
        public Contestant winner;
        public void RegestirContestants()
        {
            contestantList = UI.setContestants();
        }
        public Contestant PickWinner(List<Contestant> contestantList)
        {
            
           Contestant winner =  Dictonary.ChooseWinner(contestantList);
            return winner; 
        }
        public void displayInfo()
        {
            winner.displayInfo(); 
        } 
    }
}
