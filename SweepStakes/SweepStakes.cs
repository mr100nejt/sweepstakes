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
        public SweepStakes()
        {
            RegestirContestant();
            PickWinner();
            displayInfo()

        }
        UserInterface UI = new UserInterface();
        Dictonary Dictonary = new Dictonary();
        List<Contestant> contestantList = new List<Contestant>();
        public Contestant winner;
        public void RegestirContestant()
        {
            contestantList = UI.setContestants(); 
        }
        public Contestant PickWinner()
        {
            
            winner =  Dictonary.ChooseWinner(contestantList);
            return winner; 
        }
        public void displayInfo()
        {
            winner.displayInfo(); 
        } 
    }
}
