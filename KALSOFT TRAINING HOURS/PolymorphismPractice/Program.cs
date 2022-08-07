using System;

namespace PolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //creating objects of all classes//

            Kalsoft kalsoft_Object = new Development();

            Development development_Object = new Development();

            //HR hr_Object = new HR();

            //MobileDevelopment md_Object = new MobileDevelopment();


            //calling methods of each class and implementing polymorphism//

            kalsoft_Object.input();
            kalsoft_Object.display();

            //development_Object.input();
            //development_Object.display();

            //hr_Object.input();
            //hr_Object.display();

            //md_Object.input();
            //md_Object.display();
        }
    }
}
