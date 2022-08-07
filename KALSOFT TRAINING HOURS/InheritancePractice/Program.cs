using System;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_type_of_car, input_model_of_car;

            Console.WriteLine("Enter type of car ");
            input_type_of_car =  Console.ReadLine();

            Console.WriteLine("Enter model of car ");
            input_model_of_car = Console.ReadLine();


            Car obj = new Car(input_type_of_car, input_model_of_car); //created an object of the Car class and passed arguments that I took from the user//

            obj.display();//display function of the Car class//
        }
    }
}
