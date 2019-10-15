using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class ISweepstakesManage
    {
        interface ISweepstakesManager<T>
        {
            void InsertSweepstakes(SweepStakes sweepstakes);
            SweepStakes GetSweepstakes();
        }
    }
}
