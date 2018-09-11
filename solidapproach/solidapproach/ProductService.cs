using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class ProductService
    {
        
        public void Book(IProduct product, IRepository storage, int fare)
        {
            History.Instance.AddToLogFile("In book method setting the boolean value to true.");
            product.IsBooked = true;
            History.Instance.AddToLogFile("Calling AddToFile method "+storage.GetType()+"Product class to add the booked product details to file.");
           
            storage.Add(product, fare);

            Console.WriteLine(product.ProductType+" Booked Successfully!!");
        }

        public void Save(IProduct product, IRepository storage, int fare)
        {

            History.Instance.AddToLogFile("Calling AddToFile method " + storage.GetType() + "to add the booked product details to file.");
            storage.Add(product, fare);
            Console.WriteLine(product.ProductType + " saved Successfully!!");
        }
    }
}
