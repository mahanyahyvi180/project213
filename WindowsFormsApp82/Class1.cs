using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp82
{
    public class Tarkish
    {
        public int x
        {
            get;
            set;
        }
        public int n
        {
            get;
            set;
        }

        public int Composition(mydelegate t)
        {
            return (t(n) / t(x) * t(n - x));
        }
    }
}
