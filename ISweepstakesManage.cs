using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{

        interface ISweepstakesManager
        {
            void InsertSweepstakes(SweepStakes sweepstakes);
            SweepStakes GetSweepstakes();
        }
    
}
