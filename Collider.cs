﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_2
{
    class Collider : Component
    {
        public Collider() 
        {
            isCollide = true;
        }

        ~Collider()
        {

        }

        public bool isCollide;

    }
}
