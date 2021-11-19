using System;
using System.Linq;
using EvaPets.Data;
using EvaPets.Domain;
using static System.Console;

namespace EvaPets.UI
{
    class Program
    {
        private static StoreContext _storeContext = new StoreContext();

        static void Main(string[] args)
        {
            WriteLine("Hello EvaPets Store!");
            _storeContext.Database.EnsureCreated();
            GetStore("Before Add");
            //AddStoresByName("Store1", "Store2", "Store3", "Store4");
            AddStoresAndCities();
            GetStore("After Add:");
            Write("Press any key...");
            ReadKey();

        }

        private static void AddStoresByName(params string[] names)
        {
            /*var store = new Store { Name = "AllFarm" };
            _storeContext.Stores.Add(store);
            _storeContext.SaveChanges();*/

            foreach (var store in names)
            {
                _storeContext.Stores.Add(new Store { Name = store });
            }
            _storeContext.SaveChanges();
        }


        private static void AddStoresAndCities()
        {
            _storeContext.AddRange(
                new Store { Name = "Virgin"},
                new Store { Name = "Eden"},
                new Cities { Name = "New York"},
                new Cities { Name = "Paris"}
                );
            /*_storeContext.Stores.AddRange(
                new Store { Name = "Tower Records" },
                new Store { Name = "MyMusic" });
            _storeContext.Cities.AddRange(
                new Cities { Name = "Bogota"},
                new Cities { Name = "London" });*/
            _storeContext.SaveChanges();
        }

        private static void GetStore(string text)
        {
            var stores = _storeContext.Stores.ToList();
            WriteLine($"{text}: Store count is {stores.Count}");
            foreach (var store in stores)
            {
                WriteLine(store.Name);
            }
        }
    }
}
