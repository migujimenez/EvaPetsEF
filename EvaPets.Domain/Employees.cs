using System;
namespace EvaPets.Domain
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Store Store { get; set; }
        public int StoreId { get; set; }
    }
}
