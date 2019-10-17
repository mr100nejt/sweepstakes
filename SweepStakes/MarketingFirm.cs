using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        public int counter = 0;
        public int sweepStakesCounter = 0;

        public MarketingFirm(ISweepstakesManager storageType)
        {
           
            CreateSweepstakes(storageType);
            SeeWinners(storageType,counter); ;
        }
        public void CreateSweepstakes(ISweepstakesManager storageType)
        {
            Console.WriteLine("Would you like to create a sweep stake?");
           
            string input = Console.ReadLine();
            switch (input)
            {
                case "yes":
                    
                    bool done = false;
                    while (done == false)
                    { 
                        Console.WriteLine("what would you like to call it");
                        string name = Console.ReadLine();
                        SweepStakes sweepStake = new SweepStakes(name);
                        sweepStake.RegestirContestants();
                        storageType.InsertSweepstakes(sweepStake);
                        Console.WriteLine("are you done adding sweep stakes?");
                        string doneInput = Console.ReadLine();
                        counter = sweepStake.contestantList.Count + counter; 
                        if(doneInput == "yes")
                        {
                            done = true; 
                        }
                        else
                        {
                            sweepStakesCounter++;
                            done = false; 
                        }
                    }
                    break;   
                        case "no":
                            break;
                        default:                                    
                       
                            break; 
                    
            }
                   
                
           
        }
        public void SeeWinners(ISweepstakesManager storageType,int listCount)
        {
            Console.WriteLine("Would you like to see the winner?");
            string userInput = Console.ReadLine();
            switch (userInput)
            {


                case "yes":
                    
                         for ( int i = 0; i <= listCount; i++)
                         {
                              storageType.GetSweepstakes();
                         }
                       
                    break;

                case "no":
                                   
                    break;
                default:
                    break;
            }
        }
       

    }
}
