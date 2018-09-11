using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    public interface IProduct
    {
         string ProductType { get; set; }
        string ProductName { get; set; }
         bool IsBooked { get; set; }

        int fare { get; set; }
        //void Save(IProduct product,IRepository storage,int fare);
        //void Book(IProduct product, IRepository storage,int fare);
    }
}
