using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApi.Models
{
    public class Recipe
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public double ppu { get; set; }
        public List<Topping> topping { get; set; }
    }
}
