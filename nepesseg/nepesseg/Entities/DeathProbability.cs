using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg.Entities
{
    class DeathProbability
    {

        //nem, kor és a halálozási valószínűség
        public Gender gender { get; set; }
        public int Age { get; set; }
        public double P { get; set; }
    }
}
