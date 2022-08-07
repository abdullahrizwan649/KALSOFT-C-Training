using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsPractice
{


    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int[] myNum = { 1, 2, 3 };

            //    Console.WriteLine(myNum[10]);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //DIVISION BY ZERO EXCEPTION//

            int num_one, num_two, result;

            try
            {
                Console.WriteLine("Enter first number ");
                num_one = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number ");
                num_two = Convert.ToInt32(Console.ReadLine());

                result = num_one / num_two;

                Console.WriteLine("RESULT is " + result);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("DIVIDE BY ZERO?WTF!!!Are you dumb:>");
            }

            finally
            {
                Console.WriteLine("It's not that complicated bruh!!");
            }
            Console.ReadKey();
        }

    }
}