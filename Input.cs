using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_2
{
    class Input
    {
        public Input()
        {

        }
        ~Input()
        {

        }

        public static ConsoleKey key;

        public static bool GetKeyDown( ConsoleKey checkKey)
        {
            if ( checkKey == key)
            {
                return true;
            }

            return false;
        }
    }
}
