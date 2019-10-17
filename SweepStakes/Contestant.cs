using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant
    {
        public string First;
        public string Last;
        public string EMail;
        public int RegestrationNumber;
        
       
        public string info; 

        public Contestant()
        {
           
        }
        public void setInfo(string first,string last,string eMail, int regestrtionNumber)
        {
            First =  first;
            Last =  last;
            EMail =  eMail;
            RegestrationNumber = regestrtionNumber; 
        }
       
        public string displayInfo()
        {
            info = "first name is " + First + " last name is " + Last + " E-Mail  is " + EMail + " Regestration Number is "+ RegestrationNumber; 
            Console.WriteLine("" + info);
            Console.ReadLine();
            return info; 
        }
    }
}
