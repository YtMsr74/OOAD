using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patLab1
{
    internal abstract class Note
    {
        public string Title;
        //public abstract Note Clone();
        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
