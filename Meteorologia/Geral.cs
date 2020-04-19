using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteorologia
{
    public class Geral
    {
        public List<Weather> Weather { get; set; }
        public Main Main { get; set; }
        public int Dt { get; set; }
        public Clouds Clouds { get; set; }
        public Wind Wind { get; set; }
        public Sys sys { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
        public int id { get; set; }

    }
}
