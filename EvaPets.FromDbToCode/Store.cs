using System;
using System.Collections.Generic;

#nullable disable

namespace EvaPets.FromDbToCode
{
    public partial class Store
    {
        public Store()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
