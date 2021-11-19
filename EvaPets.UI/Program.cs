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
            //AddStore("YourPlanetPet", "The Duck");
            GetStore("After Add:");
            Write("Press any key...");
            ReadKey();

        }

        private static void AddStore(params string[] names)
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
