using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public abstract class threeDimensionalClass : Shape
    {
        public abstract double volume();
        public abstract double surface_are();
        public abstract void whoami();
    }

    public class circle3d : threeDimensionalClass
    {
        double radius;
        public circle3d(double radius)
        {
            this.radius = radius;
        }

        public override double volume()
        {
            return (4.0 / 3.0) * Math.PI * radius * radius * radius;
        }

        public override double surface_are()
        {
            return (4.0) * Math.PI * radius * radius;
        }
        public override void whoami()
        {
            Console.WriteLine("I am 3d circle");
        }
    }

    public class square3d : threeDimensionalClass
    {
        double side;
        public square3d(double side)
        {
            this.side = side;
        }

        public override double volume()
        {
            return side * side * side;
        }

        public override double surface_are()
        {
            return 6 * side * side;
        }
        public override void whoami()
        {
            Console.WriteLine("I am 3d square");
        }
    }

    public class cylinder3d : threeDimensionalClass
    {
        double r, h;
        public cylinder3d(double r, double h)
        {
            this.h = h;
            this.r = r;
        }

        public override double volume()
        {
            return Math.PI * r * r * h;
        }

        public override double surface_are()
        {
            return 2 * Math.PI * r * (r + h);
        }
        public override void whoami()
        {
            Console.WriteLine("I am 3d cylinder");
        }
    }

    public class cone3d : threeDimensionalClass
    {
        double radius, height, length;
        public cone3d(double radius, double height, double lenght)
        {
            this.radius = radius;
            this.height = height;
            this.length = lenght;
        }

        public override double volume()
        {
            return (1.0 / 3.0) * Math.PI * radius * radius * height;
        }

        public override double surface_are()
        {
            return Math.PI * radius * (radius + length);
        }
        public override void whoami()
        {
            Console.WriteLine("I am 3d cone");
        }
    }
}
