using System;

namespace program1
{
    class ShapeFactory
    {
        public static IShape GetShape(string shape, double a = 0, double b = 0, double c = 0)
        {
            IShape ishape = null;
            if (shape.Equals("triangle"))
            {
                ishape = new Triangle(a, b, c);
            }
            else if (shape.Equals("circle"))
            {
                ishape = new Circle(a);
            }
            else if (shape.Equals("square"))
            {
                ishape = new Square(a);
            }
            else if (shape.Equals("rectangle"))
            {
                ishape = new Rectangle(a, b);
            }
            else
            {
                Console.WriteLine("不支持此图形！！");
            }
            return ishape;
        }
    }
}
