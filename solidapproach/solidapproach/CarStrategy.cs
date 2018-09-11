using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class CarStrategy:IFareStrategy
    {

        public int CalculateFare(int totalFare)
        {
            History.Instance.AddToLogFile("calculating and returning fare of Car Strategy Class");
            return (totalFare + 20);
        }
    }
}
