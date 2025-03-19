using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patlab2
{
    internal abstract class Component
    {
        public string Name;
        public abstract long GetSize();
    }
}
