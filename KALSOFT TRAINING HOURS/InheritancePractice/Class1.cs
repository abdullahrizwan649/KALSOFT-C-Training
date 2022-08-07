    using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    class Vehicle
    {
        protected string type_of_car;
        
    }

    class Car : Vehicle
    {
        public string model_of_car;

        public Car(string u_type_of_car = "", string u_model_of_car = "")
        {
            type_of_car = u_type_of_car;
            model_of_car = u_model_of_car;
        }

        public void display()
        {
            Console.WriteLine("Type of CAR --> " + type_of_car);
            Console.WriteLine("Model of CAR --> " + model_of_car);
        }

        

    }
}
