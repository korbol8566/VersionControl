using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Patterns_1031.Abstractions
{
    public interface IToyFactory
    {
        Toy CreateNew();
    }
}
