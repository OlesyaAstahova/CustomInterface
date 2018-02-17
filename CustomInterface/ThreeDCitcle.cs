using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class ThreeDCitcle : Circle, IDraw3D
    {
        protected new string shapeName;

        public new void Draw()
        {
            Console.WriteLine("\nDrawing a 3D Circle");
        }

        public void Draw3D ()
        {
            Console.WriteLine("Drawing Circle in 3D!");
        }
    }
}
