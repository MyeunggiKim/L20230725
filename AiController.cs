using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_2
{
    internal class AiController : Component
    {
        public AiController() { }
        ~AiController() { }

        public override void Update()
        {
            GameObject player = Engine.Find("player");

            if (player.transform.x == transform.x &&
                player.transform.y == transform.y)
            {
                Console.WriteLine("실패");
                Engine.Quit();
                return;
            }

            Random random = new Random();
            int direction = random.Next(0, 4);
            if (direction == 0)
            {
                transform.Translate(0, -1);
            }
            if (direction == 1)
            {
                transform.Translate(0, 1);
            }
            if (direction == 2)
            {
                transform.Translate(-1, 0);
            }
            if (direction == 3)
            {
                transform.Translate(1, 0);
            }
        }
    }
}
