using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class HotelStrategy:IFareStrategy
    {
        public int CalculateFare(int totalFare)
        {
            History.Instance.AddToLogFile("calculating and returning fare of Hotel Strategy Class");
            return (totalFare + 50);
        }
    }
}
