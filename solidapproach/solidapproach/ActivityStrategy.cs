using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class ActivityStrategy:IFareStrategy
    {
        public int CalculateFare(int totalFare)
        {
            History.Instance.AddToLogFile("calculating and returning fare of Activity Strategy Class");
            return (totalFare + 200);
        }
    }
}
