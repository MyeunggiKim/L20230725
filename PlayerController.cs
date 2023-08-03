using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_2
{
    class PlayerController : Component
    {
        public PlayerController() 
        { 
        }
        ~PlayerController() 
        { 
        }
        public override void Update()
        {
            if(Input.GetKeyDown(ConsoleKey.W))
            {                
                transform.Translate(0, -1);            
            }
            if(Input.GetKeyDown(ConsoleKey.S))
            {
                transform.Translate(0, 1);
            
            }
            if(Input.GetKeyDown(ConsoleKey.A))                
            {
                transform.Translate(-1, 0);
            }
            if (Input.GetKeyDown(ConsoleKey.D))
            {
                transform.Translate(1, 0);
            }
        }
    }
}
