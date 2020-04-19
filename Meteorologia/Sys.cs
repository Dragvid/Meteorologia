using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteorologia
{
    public class Sys
    {
        public int Type { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        public int Id { get; set; }
        public double Message { get; set; }
        public string Country { get; set; }
    }
}
