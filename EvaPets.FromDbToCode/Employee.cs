using System;
using System.Collections.Generic;

#nullable disable

namespace EvaPets.FromDbToCode
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StoreId { get; set; }

        public virtual Store Store { get; set; }
    }
}
