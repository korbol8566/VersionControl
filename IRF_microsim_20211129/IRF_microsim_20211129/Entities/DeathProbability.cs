using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_microsim_20211129.Entities
{
    public class DeathProbability
    {
        public int Age { get; set; }
        public int childrenCount { get; set; }
        public double deathProbability { get; set; }
    }
}
