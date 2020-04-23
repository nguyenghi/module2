using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();

            Console.WriteLine(shape);

            shape = new Shape("red", false);

            Console.WriteLine(shape);
            Console.WriteLine("------------------------");
            Circle circle = new Circle();

                Console.WriteLine(circle);
                circle = new Circle(3.5);
                Console.WriteLine(circle);
                circle = new Circle(3.5, "indigo", false);
                Console.WriteLine(circle);
        }
    }
    public class Shape
    {
        protected string color = " green";
        protected bool filled = true;
        public Shape()
        {

        }
        public Shape( string color, bool filled){
            this.color = color;
            this.filled = filled;
        }
        public String GetColor()
        {

            return color;

        }
        public void SetColor(String color)
        {

            this.color = color;

        }
        public bool IsFilled()
        {

            return filled;

        }
        public void SetFilled(bool filled)
        {

            this.filled = filled;

        }
        public override String ToString()
        {

            return "A Shape with color of "
                    + GetColor()
                    + " and "
                    + (IsFilled() ? "filled" : "not filled");

        }
    }
    public class Circle : Shape

    {
        private double radius = 1.0;
        public Circle()
        {

        }
        public Circle(double radius)
        {

            this.radius = radius;

        }
        public Circle(double radius, String color, bool filled) : base(color, filled)
        {

            this.radius = radius;

        }
        public double GetRadius()
        {

            return radius;

        }
        public void SetRadius(double radius)
        {

            this.radius = radius;

        }
        public double GetArea()
        {

            return radius * radius * Math.PI;

        }
        public double GetPerimeter()
        {

            return 2 * radius * Math.PI;

        }
        public override String ToString()
        {

            return "A Circle with radius="

                    + GetRadius()

                    + ", which is a subclass of "

                    + base.ToString();

        }

    }
}
