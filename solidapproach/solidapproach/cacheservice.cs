using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class cacheservice
    {
        ICache cacheInstance;
        public cacheservice(string cache)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == cache);
                 cacheInstance =(ICache)Activator.CreateInstance(productType);
        }

        public ICache returnInstance()
        {
            return cacheInstance;
        }
    }
}
