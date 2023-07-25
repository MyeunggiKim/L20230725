using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_2
{
    class MeshRenderer : Component
    {
        protected MeshFilter meshFilter;
        public MeshRenderer()
        { 
        }
        ~MeshRenderer()
        {
        }

        public override void Start()
        {
            foreach (var component in gameObject.components)
            {
                if (component is MeshFilter)
                {
                    meshFilter=(component as MeshFilter);
                }
            }
        }

        public virtual void Render()
        {
            Console.SetCursorPosition(transform.x, transform.y);
            Console.WriteLine(meshFilter.Shape);
        }
        //Meshfilter에서 정보를 가져와서 그걸 그리는
        //GameObject의 정보를 알아야 함
        //나를 소유한 GameObject로 부터 MeshFilter를 찾아서 Shape를 가져온다

    }
}
