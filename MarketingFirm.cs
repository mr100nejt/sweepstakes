using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
        SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
        public MarketingFirm()
        {
            CreateSweepstakes();
            SeeWinners();
        }
        public void CreateSweepstakes()
        {
            Console.WriteLine("Would you like to create a sweep stake?");
            string input = Console.ReadLine();
            switch (input)
            {
                case "yes":
                    Console.WriteLine("what would you like to call it");
                    string name = Console.ReadLine(); 
                    SweepStakes sweepStake = new SweepStakes(name);
                    Console.WriteLine("would you like to use a stack or queue?");
                    string userInput = Console.ReadLine();
                    switch (userInput) 
                    { 

                  
                        case "queue":
                            sweepstakesQueueManager.InsertSweepstakes(sweepStake);
                            CreateSweepstakes();

                            break;
                           
                        case "stack":
                            sweepstakesStackManager.InsertSweepstakes(sweepStake);
                            CreateSweepstakes();
                            break;
                        default:
                            break;
                    }
                    break;
                        case "no":
                            break;
                        default:                                    
                         CreateSweepstakes();
                            break; 
            }
                   
                
            
        }
        public void SeeWinners()
        {
            Console.WriteLine("Would you like to see the winner of your Stack or Queue?");
            string userInput = Console.ReadLine();
            switch (userInput)
            {


                case "queue":
                    for (int i = 0; i < SweepstakesQueueManager.sweepStakesQueue.Count;)
                    {
                        sweepstakesQueueManager.GetSweepstakes();
                    }
                    break;

                case "stack":
                    for (int i = 0; i < SweepstakesStackManager.sweepStakesStack.Count;)
                    {
                        sweepstakesStackManager.GetSweepstakes();
                    }                    
                    break;
                default:
                    break;
            }
        }
       

    }
}
