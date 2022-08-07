using System;

namespace ClassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals Bear = new Animals();

            Bear.name = "Masha";
            Bear.age = 100000;
            Bear.extinct = false;


            Animals Panda = new Animals();

            Panda.name = "BOYYY743";
            Panda.age = 19;
            Panda.extinct = true;

            Bear.details();
            Panda.details();



        }
    }
}
