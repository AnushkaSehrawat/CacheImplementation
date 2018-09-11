using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class Cache:ICache
    {
       

        ObjectCache cache = MemoryCache.Default;
       
       public void AddtoCache(string key, IProduct value)
        {
            if (cache.Get(key) == null)
            {
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddHours(1.0);
                cache.Add(key, value, cacheItemPolicy);
            }

        }
       public IProduct getFromCache(string key, IProduct value)
        {
            return (IProduct)cache.Get(key);
        }
    }
}
