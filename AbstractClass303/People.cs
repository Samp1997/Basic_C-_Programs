using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass303
{
    public abstract class People 
    {
        public string FirstName;

        public string LastName;

        public void SayName()
        {
            Console.WriteLine("Name :  " + FirstName + " " + LastName);
        }


    }

     class Employee : People
    {
        public int id;

        public void SayName()
        {
            Console.WriteLine("Name :  " + FirstName + " " + LastName);
        }

    }
}
