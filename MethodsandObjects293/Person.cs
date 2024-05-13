using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsandObjects293
{
    class Person
    {
        public string FirstName;

        public string LastName;

        public void SayName()
        {
            Console.WriteLine("Name :  "  + FirstName + " " + LastName);  
        }


    }

    class Employee : Person
    {
        public int id;
        

        
    }
}
