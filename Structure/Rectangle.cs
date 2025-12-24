using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct Rectangle
    {
        public int Length;
        public int Width;

        public int Area()
        {
            return Length * Width;
        }
    }
}
