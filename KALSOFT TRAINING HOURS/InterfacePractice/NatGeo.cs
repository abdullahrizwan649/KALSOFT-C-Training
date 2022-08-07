using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
  
    interface IPrey
    {
        void run();
    }

    interface IPredator
    {
        void hunt();
    }


    class Fish : IPredator,IPrey
    {
        public void run()
        {
            Console.WriteLine("SKRRRRR");
        }

        public void hunt()
        {
            Console.WriteLine("YUM YUM!COME HERE");
        }
    }
    
}
