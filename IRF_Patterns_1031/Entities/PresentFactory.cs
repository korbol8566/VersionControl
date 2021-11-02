using IRF_Patterns_1031.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Patterns_1031.Entities
{
    class PresentFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Present();
        }
    }
}
