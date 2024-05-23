using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAssignment307
{
    interface IQuittable
    {


        public void Quit(Person person);      
        
    }

    class Employee : Person
    {
        public string FirstName;

        public string LastName;

        public int id;

        public void SayName()
        {
            Console.WriteLine("Name :  " + FirstName + " " + LastName);
        }



    }
}
