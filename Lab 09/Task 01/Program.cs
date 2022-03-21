using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circleClass2d circle2d = new circleClass2d(5.0);

            Console.WriteLine(circle2d.Area().ToString());
            Console.WriteLine(circle2d.Perimeter().ToString());
            circle2d.whoami();


            squareClass2d square2d = new squareClass2d(3.0);

            Console.WriteLine(square2d.Area().ToString());
            Console.WriteLine(square2d.Perimeter().ToString());
            square2d.whoami();


            rectangleClass2d rec2d = new rectangleClass2d(5.0, 7.0);

            Console.WriteLine(rec2d.Area().ToString());
            Console.WriteLine(rec2d.Perimeter().ToString());
            rec2d.whoami();


            rhombusClass2d rh2d = new rhombusClass2d(5.0, 4.0, 6.0);

            Console.WriteLine(rh2d.Area().ToString());
            Console.WriteLine(rh2d.Perimeter().ToString());
            rh2d.whoami();


            circle3d c3d = new circle3d(4.0);

            Console.WriteLine(c3d.volume().ToString());
            Console.WriteLine(c3d.surface_are().ToString());
            c3d.whoami();

            cylinder3d cyl3d = new cylinder3d(5.0, 7.0);

            Console.WriteLine(cyl3d.volume().ToString());
            Console.WriteLine(cyl3d.surface_are().ToString());
            cyl3d.whoami();

            Console.ReadKey();

        }
    }
}
