using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        public void CreateSweepstakes()
        {
            Console.WriteLine("Would you like to create a sweep stake?");
            string input = Console.ReadLine();
            switch (input)
            {
                case "yes":
                    SweepStakes sweepStake = new SweepStakes();
                    Console.WriteLine("what would you like it called");
                    sweepStake.sweepStakesName = Console.ReadLine(); 
                    break;
                case "no":
                    break;
                default:
                    CreateSweepstakes();
                    break; 
            }
        }
       

    }
}
