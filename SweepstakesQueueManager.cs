using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
       public static Queue<SweepStakes> sweepStakesQueue = new Queue<SweepStakes>();

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {

            sweepStakesQueue.Enqueue(sweepstakes);
           

        }
        public SweepStakes GetSweepstakes()
        {
             SweepStakes sweepStackQueue = sweepStakesQueue.Dequeue();
             Console.WriteLine("You got " + sweepStackQueue.sweepStakesName);
             Contestant Winner= sweepStackQueue.PickWinner(sweepStackQueue.contestantList);
             Console.WriteLine("the winner of " + sweepStackQueue.sweepStakesName + " was " + Winner.displayInfo());
             return sweepStackQueue;
        }
    }
}
