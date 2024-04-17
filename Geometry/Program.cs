using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polygon P = new Polygon();
            P.Color = "Blue";
            P.Height = 5;

            Rectangle r = new Rectangle(5, 6);
            Console.WriteLine(r.Perimeter());

            Square s = new Square(6);
            Console.WriteLine(s.Area());
        }
    }
}
