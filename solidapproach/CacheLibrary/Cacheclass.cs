using solidapproach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheLibrary
{
    class Cacheclass : ICache
    {
        IProduct prod;
        private const string CacheKey = "availableStocks";
        public Cacheclass(IProduct prod)
        {
            this.prod = prod;
        }
        public void AddToCache()
        {
            
    
        }
           
        }

    }

