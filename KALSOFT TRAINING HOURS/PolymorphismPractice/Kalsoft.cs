using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismPractice
{
    class Kalsoft
    {
       public int num_of_employees;

        public virtual void input()
        {
            Console.WriteLine("Enter number of employees in Kalsoft ");
            num_of_employees = Convert.ToInt32(Console.ReadLine());
        }


        public virtual void display()
        {
            Console.WriteLine(num_of_employees+ " employees in Kalsoft");
        }

        public void moosa()
        {
            Console.WriteLine("HEllo World");
        }
    }

    class Development : Kalsoft
    {
        public override void input()
        {
            Console.WriteLine("Enter number of employees in Development ");
            num_of_employees = Convert.ToInt32(Console.ReadLine());
        }

        public override void display()
        {
            Console.WriteLine(num_of_employees + " employees in Kalsoft");
        }

    }
    
    class HR : Kalsoft
    {
        public override void input()
        {
            Console.WriteLine("Enter number of employees in HR ");
            num_of_employees = Convert.ToInt32(Console.ReadLine());
        }

        public override void display()
        {
            Console.WriteLine(num_of_employees + " employees in HR");
        }

    }

    class MobileDevelopment : Kalsoft
    {
        public override void input()
        {
            Console.WriteLine("Enter number of employees in Mobile Development ");
            num_of_employees = Convert.ToInt32(Console.ReadLine());
        }

        public override void display()
        {
            Console.WriteLine(num_of_employees + " employees in Mobile Development");
        }

    }

}
