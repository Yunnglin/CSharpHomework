using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IShape triangle = ShapeFactory.GetShape("triangle", 3, 4, 5);
                triangle.GetArea();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unsupported graphics");
            }
            try
            {
                IShape circle = ShapeFactory.GetShape("circle", 3);
                circle.GetArea();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unsupported graphics");
            }
            try
            {
                IShape square = ShapeFactory.GetShape("square", 3);
                square.GetArea();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unsupported graphics");
            }
            try
            {
                IShape rectangle = ShapeFactory.GetShape("rectangle", 3, 4);
                rectangle.GetArea();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unsupported graphics");
            }
        }
    }

    class Triangle : IShape
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void GetArea()
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("The sides of the triangle are a = {0},b = {1},c = {2}", a, b, c);
                double p = a + b + c;
                double h = p / 2;
                double area = Math.Sqrt(h * (h - a) * (h - b) * (h - c));
                Console.WriteLine("Area of the triangle is {0}", area);
            }
            else Console.WriteLine("Unable to form a triangle！");
        }
    }

    class Circle : IShape
    {
        private readonly double r;

        public Circle(double r)
        {
            this.r = r;
        }
        public void GetArea()
        {
            if (r >= 0)
            {
                Console.WriteLine("The radius of the circle is " + r);
                double area = Math.PI * r * r;
                Console.WriteLine("Area of the circle is {0}", area);
            }
            else Console.WriteLine("Unable to form a circle！");
        }
    }

    class Square : IShape
    {
        private readonly double a;
        public Square(double a)
        {
            this.a = a;
        }
        public void GetArea()
        {
            if (a >= 0)
            {
                Console.WriteLine("The side of the square is " + a);
                double area = a * a;
                Console.WriteLine("Area of the square is {0}", area);
            }
            else Console.WriteLine("Unable to form a square！");
        }
    }

    class Rectangle : IShape
    {
        private readonly double a;
        private readonly double b;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void GetArea()
        {
            if (a >= 0 && b >= 0)
            {
                Console.WriteLine("The sides of the rectangle is {0} and {1}", a, b);
                double area = a * b;
                Console.WriteLine("Area of the rectangle is {0}", area);
            }
            else Console.WriteLine("Unable to form a rectangle！");
        }
    }
}
