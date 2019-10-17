using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
     class SweepstakesStackManager : ISweepstakesManager
    {
        public static Stack<SweepStakes> sweepStakesStack = new Stack<SweepStakes>();

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {

            sweepStakesStack.Push(sweepstakes);

        }
        public SweepStakes GetSweepstakes()
        {
           SweepStakes stackSweepStack = sweepStakesStack.Pop();
            Console.WriteLine("You got " + stackSweepStack.sweepStakesName);
            Contestant Winner = stackSweepStack.PickWinner(stackSweepStack.contestantList);
            Console.WriteLine("the winner of " + stackSweepStack.sweepStakesName + " was " + Winner.displayInfo());
            return stackSweepStack; 
        }
    }
}
