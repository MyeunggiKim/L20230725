using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_2
{
    class MeshFilter : Component
    {
        public MeshFilter ()
        {
            Shape = ' ';
        }

        public MeshFilter(char newShape)
        {
            Shape = newShape;
        }

        ~MeshFilter ()
        {

        }

        public char Shape;
    }
    
}
