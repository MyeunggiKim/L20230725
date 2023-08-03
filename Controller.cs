using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_2
{
    class Controller : Collider
    {
        public Controller()
        {            
        }
        ~Controller()
        {
        }
        protected bool PredictiMove(int newX, int newY)
        {
            foreach (var gameObject in Engine.GetInstance().GetAllGameObjects())
            {
                //다음 좌표의 오브젝트 확인
                if (gameObject.transform.x == newX &&
                    gameObject.transform.y == newY)
                {
                    //모든 컴포넌트 가져오기
                    foreach (var component in gameObject.components)
                    {
                        if (component is Collider)
                        {
                            Collider checkComponent = component as Collider;
                            if (component is Collider)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
