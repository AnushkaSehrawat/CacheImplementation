using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class Program
    {
        static void Main(string[] args)
        {
            
            History.Instance.AddToLogFile("----In Main -----");
            gettingtype obj = new gettingtype();
            ProductService serviceobj = new ProductService();
            int option;
            string itemType;
            string storageType;
            Console.WriteLine("Enter the type of product you want 1:CarProduct 2: HotelProduct 3: AirProduct 4: ActivityProduct");
            itemType = Console.ReadLine();
           
            History.Instance.AddToLogFile("Calling Function DetermineType to determine the type of object to be created.");
            IProduct finalObject= obj.DetermineItemType(itemType);
            History.Instance.AddToLogFile("Getting the class of strategy class which is to be instanciated");
            IFareStrategy fareItemType = obj.GetItemTypeForFare(finalObject);
            Console.WriteLine("Enter which operartion you want to perform: 1:book 2:save 3: GetDetailsFromDatabaseorCache ");
            option = Int32.Parse(Console.ReadLine());
            History.Instance.AddToLogFile("Entering into switch mode");
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter option where you want to save the details: 1: FileRepository 2: SqlRepository");
                        storageType = Console.ReadLine();
                        IRepository finalstorage = obj.GetStorageType(storageType);
                        History.Instance.AddToLogFile("Calling book method of service class to add the details to storage.");
                        serviceobj.Book(finalObject,finalstorage,fareItemType.CalculateFare(finalObject.fare));
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Enter option where you want to save the details: 1: File 2: Database");
                        storageType = Console.ReadLine();
                        IRepository finalstorage = obj.GetStorageType(storageType);
                        History.Instance.AddToLogFile("Calling save method of service class to add the details to storage.");
                        serviceobj.Save(finalObject,finalstorage, fareItemType.CalculateFare(finalObject.fare));
                        break;
                    }
                case 3:
                    {
                        
                        cacheservice serviceobject = new cacheservice("Cache");
                        ICache cacheobject = serviceobject.returnInstance();
                        cacheDecorator decoratorbject = new cacheDecorator(cacheobject,finalObject);
                        decoratorbject.getDataFromCacheOrSql();
                       

                        break;
                    }

              
            }
            Console.ReadKey();
        }
    }
}
