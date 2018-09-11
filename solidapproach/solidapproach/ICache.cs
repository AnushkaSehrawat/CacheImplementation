using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
   public interface ICache


    {
      
        void AddtoCache(string key, IProduct value);
        IProduct getFromCache(string key, IProduct value);
    }
}
