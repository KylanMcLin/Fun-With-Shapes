using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_6
{
    class FunWithShapes
    {

        static void Main(string[] args)
        {

            Rectangle MyRectangle = new Rectangle(100, 50);
            Square MySquare = new Square(12);
            Triangle MyTriangle = new Triangle(14, 20);

            ShapePrinter(MyRectangle);
            ShapePrinter(MySquare);
            ShapePrinter(MyTriangle);

            Console.ReadLine();

        }

        public static void ShapePrinter(Shape shape)
        {
            Console.WriteLine(shape.ToString());
            Console.WriteLine();
        }

    }

    abstract class Shape
    {

        private float length; public float Length { get; set; }

        private float width; public float Width { get; set; }

        private float area; public float Area { get; set; }

        public abstract float CalcArea();

    }

    class Rectangle : Shape
    {
        public Rectangle(float LengthPassed, float WidthPassed)
        {
            Length = LengthPassed;
            Width = WidthPassed;
            CalcArea();
        }


        public override float CalcArea()
        {
            return Area = Length * Width;
        }


        public override string ToString()
        {
            return string.Format("Rectangle, Length: {0}, Width: {1}, Area: {2}", Length, Width, Area);
        }
    }

    class Square : Rectangle
    {

        public Square(float LengthPassed) : base(LengthPassed, LengthPassed)
        {
            Length = LengthPassed;
            CalcArea();
        }

        public override float CalcArea()
        {
            return Area = Length * Length;
        }

        public override string ToString()
        {
            return string.Format("Square, Length: {0}, Area: {1}", Length, Area);
        }
    }

    class Triangle : Shape
    {

        float Height;

        public Triangle(float LengthPassed, float HeightPassed)
        {
            Length = LengthPassed;
            Height = HeightPassed;
            CalcArea();
        }

        public override float CalcArea()
        {
            return Area = (Length * Height) / 2;
        }

        public override string ToString()
        {
            return string.Format("Triangle, Length: {0}, Height: {1}, Area: {2}", Length, Height, Area);
        }


    }


}


