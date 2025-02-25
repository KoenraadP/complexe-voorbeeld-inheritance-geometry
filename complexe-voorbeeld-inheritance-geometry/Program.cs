using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_voorbeeld_inheritance_geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle r = new Rectangle();
            //r.Color = "Red";
            //Console.WriteLine(r.Color);

            Polygon p = new Polygon(10);
            p.Color = "Blue";
            Console.WriteLine(p.Color);

        }
    }
}
