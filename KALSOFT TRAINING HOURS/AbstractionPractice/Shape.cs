using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionPractice
{
  abstract class Shape 
    {
        public int x;
        public int y;
        abstract public int Area();
        public virtual void Display()
        {
            Console.WriteLine("base");
        }
    }

    class Rectangle: Shape
    {
        public Rectangle(int side)
        {
            x = side;
        }

        public override int Area()
        {
            y = x * x;

            return y;
        }

        public override void Display()
        {
            Console.WriteLine("Area is " + y);

        }


    }
}
