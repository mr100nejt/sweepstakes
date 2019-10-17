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
           
        }

        public List<Contestant> setContestants()
        {
          Console.WriteLine("would you like too add a contestant?");
          string input =   Console.ReadLine();
            bool done = false; 
            switch (input)
            {
                case "yes":
                    while (done == false)
                    {
                        Dictonary Dictonary = new Dictonary();
                        Contestant newPerson = new Contestant();
                        Console.WriteLine("What is their first name");
                        newPerson.First = Console.ReadLine();
                        Console.WriteLine("What is their last name");
                        newPerson.Last = Console.ReadLine();
                        Console.WriteLine("What is their Email ");
                        newPerson.EMail = Console.ReadLine();
                        Console.WriteLine("What is their regestration number");
                        newPerson.RegestrationNumber = Convert.ToInt32(Console.ReadLine());
                        contestantList = Dictonary.insert(newPerson, newPerson.First, newPerson.Last, newPerson.EMail, newPerson.RegestrationNumber);
                        Console.WriteLine("are you done adding Contestants?");
                        string doneInput = Console.ReadLine();
                        if (doneInput == "yes")
                        {
                            done = true;
                        }
                        else
                        {
                            done = false;
                        }
                    }

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
