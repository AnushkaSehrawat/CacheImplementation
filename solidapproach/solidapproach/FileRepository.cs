using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class FileRepository
    {
        string path = @"C:\savefile.txt";
        public void Add(IProduct product,int fare)
        {
            History.Instance.AddToLogFile("Adding content to the file.");
            
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Product Type: "+product.ProductType);
                sw.WriteLine("Product Name: "+product.ProductName);
                sw.WriteLine("Product Fare: "+fare);
                sw.WriteLine("IsBooked: "+product.IsBooked);
               
            }

        }
    }
}
