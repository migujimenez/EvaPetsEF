using System.Collections.Generic;

namespace EvaPets.Domain
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employees> Employees { get; set; } = new List<Employees>();
        public List<Cities> Cities { get; set; } = new List<Cities>();
    }
}
