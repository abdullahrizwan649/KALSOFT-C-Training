using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesPractice
{
   public class Animals
    {
        private const string Arg0 = " years old.";
        public string name;
        public int age;
        public bool extinct;

        public void details()
        {
            Console.WriteLine(name + " is "+ age + " years old." );

            if (extinct == true)
            {
                Console.WriteLine(name + " is not extinct");
            }

            else
            {
                Console.WriteLine(name + " is extinct ;(");
            }
        }
    }
}
