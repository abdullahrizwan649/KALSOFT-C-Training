using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop_check = true;
            do
            {
                Console.WriteLine("\t\n\n CALCULATOR\n");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Subtract");
                Console.WriteLine("3.Multiply");
                Console.WriteLine("4.Divide");
                Console.WriteLine("5.EXIT");


                int choice =  Convert.ToInt32(Console.ReadLine());

                if(choice>=1 && choice<=5)
                { }

                else
                {
                    Console.WriteLine("\nEnter a number between 1-5");
                    continue;
                }

                if (choice==5)
                {
                    break;
                }
                int input_one, input_two;

                Console.Write("Enter first number ");
                input_one = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter second number ");
                input_two = Convert.ToInt32(Console.ReadLine());




                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("\nSum of numbers is " + Add(input_one, input_two));
                            break;
                        }

                    case 2:
                        {
                            Console.Write("\nDifference of numbers is " + Subtract(input_one, input_two));
                            break;
                        }

                    case 3:
                        {
                            Console.Write("\nProduct of numbers is " + Multiply(input_one, input_two));
                            break;
                        }

                    case 4:
                        {
                            try
                            {
                                Console.Write("\nQuotient of numbers is " + Divide(input_one, input_two));
                            }
                            catch (DivideByZeroException div)
                            {
                                Console.WriteLine(div.Message);
                            }
                            //catch (Exception ex)
                            //{
                            //    Console.WriteLine(ex.Message);
                            //}
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("SOMETHING's WRONG");
                            break;
                        }
                }
            } while (loop_check == true);

        }

        static int Add(int num_one, int num_two)
        {
            int added = num_one + num_two;
            return added;
        }

        static int Subtract(int num_one, int num_two)
        {
            int subbed = num_one - num_two;
            return subbed;
        }

        static int Multiply(int num_one, int num_two)
        {
            int multiplied = num_one * num_two;
            return multiplied;
        }

        static int Divide(int num_one, int num_two)
        {
            int divided = num_one / num_two;
            return divided;
        }
    }
}
