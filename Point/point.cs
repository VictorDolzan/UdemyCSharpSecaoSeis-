using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    struct Point
    {
        public double x;
        public double y;

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
            
        }
    }
}