using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    public class CarProduct:IProduct
    {
       
        public string prodtype = "Car";
        public string prodname = "BMW";
        public bool isbooked = false;
        public int Fare = 30;
        public string ProductType { get { return prodtype; } set { prodtype = value; } }
        public string ProductName { get { return prodname; } set { prodname = value; } }
        public bool IsBooked  {get { return isbooked; } set { isbooked = value; } }

        public int fare { get { return Fare; } set { Fare = value; } }
       
    }
}
