using System;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();

            Console.WriteLine("I AM STRONG HUHUHU");
            fish.hunt();

            Console.WriteLine("\nI AM WEAK MAMAMAMAM");
            fish.run();

        }
    }
}
