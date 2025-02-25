using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_voorbeeld_inheritance_geometry
{
    class Polygon : Shape
    {
        public int Height { get; set; }

        public Polygon(int height, string color) : base(color)
        {
            Height = height;
        }
    }
}
