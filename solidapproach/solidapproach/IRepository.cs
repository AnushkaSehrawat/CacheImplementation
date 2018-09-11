using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    public interface IRepository
    {
        void Add(IProduct product,int fare);
        void Get(IProduct product);
    }
}
