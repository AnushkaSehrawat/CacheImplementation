using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class AirStrategy:IFareStrategy
    {
        public int CalculateFare(int totalFare)
        {
            History.Instance.AddToLogFile("calculating and returning fare of Air Strategy Class");
            return (totalFare + 100);
        }
    }
}
