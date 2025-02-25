using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_voorbeeld_inheritance_geometry
{
    class Rectangle : Polygon
    {
        // de Width eigenschap zat nog niet in de base class
        public int Width { get; set; }
    }
}
