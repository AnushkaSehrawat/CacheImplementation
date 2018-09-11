using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class HotelProduct:IProduct
    {
        FileRepository fileobj = new FileRepository();
        public string prodtype = "Hotel";
        public string prodname = "Hyatt";
        public bool isbooked = false;
        public int Fare = 50;
        public string ProductType { get { return prodtype; } set { prodtype = value; } }
        public string ProductName { get { return prodname; } set { prodname = value; } }
        public bool IsBooked { get { return isbooked; } set { isbooked = value; } }
        public int fare { get { return Fare; } set { Fare = value; } }

        
    }
}
