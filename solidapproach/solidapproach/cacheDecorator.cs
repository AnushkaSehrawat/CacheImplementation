using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class cacheDecorator:ICacheDecorator
    {
        ICache reference;
        ObjectCache cache = MemoryCache.Default;
        IProduct productReference;
        public cacheDecorator(ICache reference, IProduct product)
        {
            this.reference = reference;
            productReference = product;
        }

        public void getDataFromCacheOrSql()
        {
            if (cache.Contains(productReference.ProductType))
            {

                IProduct refobject = reference.getFromCache(productReference.ProductType, productReference);
                Console.WriteLine(refobject.ProductName);
                Console.WriteLine(refobject.IsBooked);
                Console.WriteLine(refobject.fare);
            }
            else
            {
                SqlRepository repo = new SqlRepository();
                reference.AddtoCache(productReference.ProductType,productReference);
                repo.Get(productReference);
              
            }
        }

    }
}
