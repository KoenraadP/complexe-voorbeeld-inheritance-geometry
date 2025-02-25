using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_voorbeeld_inheritance_geometry
{
    class Circle : Ellipse
    {
        public int Radius
        {
            get => Height;
            set => Height = value;
        }

        public Circle(int radius) : base(radius, radius)
        {

        }
    }
}
