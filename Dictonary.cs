using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Dictonary
    {
        public int winnerNumber; 
        public Contestant winner; 
        List<Contestant> contestantList = new List<Contestant>();
            public List<Contestant> insert(Contestant newPerson, string first, string last, string eMail, int regestrtionNumber)
            {      
                    newPerson.setInfo(first, last, eMail, regestrtionNumber);
                    contestantList.Add(newPerson);
                    return contestantList;
            }
        public Contestant ChooseWinner(List<Contestant> cList)
        {
            RandomNumber(1, cList.Count); 

            for (int i = 0; i <= contestantList.Count; i++)
            {
                if (cList[i].RegestrationNumber == winnerNumber)
                {
                    winner = cList[i]; 
                    break; 
                }
            }
            return winner; 

        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            winnerNumber =  random.Next(min, max);
            return winnerNumber; 
        }
    }

}

