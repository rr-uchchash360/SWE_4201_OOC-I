using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public abstract class twoDimensional : Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
        public abstract void whoami();
    }

    public class circleClass2d : twoDimensional
    {
        double radius;
        public circleClass2d(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return (Math.PI * (radius * radius));
        }
        public override double Perimeter()
        {
            return (2 * Math.PI * radius);
        }

        public override void whoami()
        {
            Console.WriteLine("I am 2d Circle");
        }
    }
    public class squareClass2d : twoDimensional
    {
        double side;
        public squareClass2d(double side)
        {
            this.side = side;
        }
        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return 4 * side;
        }

        public override void whoami()
        {
            Console.WriteLine("I am 2d Square");
        }
    }

    public class rectangleClass2d : twoDimensional
    {
        double a, b;
        public rectangleClass2d(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            return (a * b);
        }
        public override double Perimeter()
        {
            return 2 * (a + b);
        }

        public override void whoami()
        {
            Console.WriteLine("I am 2d Rectangle");
        }
    }
    public class rhombusClass2d : twoDimensional
    {
        double side, dp, dq;
        public rhombusClass2d(double side, double dp, double dq)
        {
            this.side = side;
            this.dp = dp;
            this.dq = dq;
        }
        public override double Area()
        {
            return (0.5 * dp * dq);
        }
        public override double Perimeter()
        {
            return 4 * side;
        }

        public override void whoami()
        {
            Console.WriteLine("I am 2d Rhombus");
        }
    }
}
