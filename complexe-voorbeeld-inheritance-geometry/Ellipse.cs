using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_voorbeeld_inheritance_geometry
{
    class Ellipse
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Ellipse(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
}
