using System;

namespace DemoAbstraction
{
    abstract class Shape
    {
        //abstract Method
        //No Direct access
        public abstract int Area();
    }


    // square class inheriting
    // the Shape class
    class Square : Shape
    {
        private int side;

        public Square(int x = 0)
        {
            side = x;
        }

        //Override of the Abstract Method
        public override int Area()
        {
            Console.WriteLine("Area of Square : ");
            return (side * side);
        }
    }


    class Geeks
    {
        static void Main(string[] args)
        {

            // creating reference of Shape class
            // which refer to Square class instance
            Shape sh = new Square(4);

            // calling the method
            double result = sh.Area();

            Console.Write("{0}", result);

        }
    }
}