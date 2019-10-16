using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("would you like to use a stack or queue to store your sweepstakes?");
            string userInput = Console.ReadLine();
            ISweepstakesManager sweepStakesManager;


            switch (userInput)
            {
              
                

                case "queue":
                    sweepStakesManager = new SweepstakesQueueManager();
                    MarketingFirm MFQ = new MarketingFirm(sweepStakesManager);
                    break;

                case "stack":
                    sweepStakesManager = new SweepstakesStackManager();
                     MarketingFirm MFS = new MarketingFirm(sweepStakesManager); 
                    break;
                default:
                    break;
            }
           
        }
    }
}
