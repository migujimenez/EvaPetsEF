using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvaPets.Domain
{
    public class Cities
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        public List<Store> Store { get; set; } = new List<Store>();
    }
}
