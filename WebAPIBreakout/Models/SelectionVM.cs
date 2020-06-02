using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIBreakout.Models
{
    public class SelectionVM
    {
        public List<Person> People { get; set; }
        public List<Planet> Planets { get; set; }
    }
}
