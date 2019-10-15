using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class UserInterface
    {
        List<Contestant> contestantList = new List<Contestant>();
        public UserInterface()
        {
            setContestants(); 
        }

        public List<Contestant> setContestants()
        {
          Console.WriteLine("would you like too add a contestant?");
          string input =   Console.ReadLine();
            switch (input)
            {
                case "yes":
                    Dictonary Dictonary = new Dictonary();
                    Contestant newPerson = new Contestant(); 
                    Console.WriteLine("What is their first name");
                    newPerson.First = Console.ReadLine();
                    Console.WriteLine("What is their last name");
                    newPerson.Last = Console.ReadLine();
                    Console.WriteLine("What is their Email name");
                    newPerson.EMail = Console.ReadLine();
                    Console.WriteLine("What is their regestration number");
                    newPerson.RegestrationNumber = Convert.ToInt32(Console.ReadLine());
                   contestantList =  Dictonary.insert(newPerson,newPerson.First, newPerson.Last, newPerson.EMail, newPerson.RegestrationNumber);
                    setContestants(); 
                    
                    break;
                case "no":
                    break;
                default:
                    setContestants();
                    break; 
            }

            return contestantList; 
        }
        
    
    }
}
