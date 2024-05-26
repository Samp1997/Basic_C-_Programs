using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAssignment307
{
    class Employee : Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I quit"); 
        }

        public string FirstName;

        public string LastName;

        public int id;

        public void SayName()
        {
            Console.WriteLine("Name :  " + FirstName + " " + LastName);
        }
    }
}
