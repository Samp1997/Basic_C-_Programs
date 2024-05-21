using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass303
{
    public abstract class Person
    {
        public string FirstName;

        public string LastName;

        public void SayName()
        {
            Console.WriteLine("Name :  " + FirstName + " " + LastName);
        }


    }

    class Employee : Person
    {
        public int id;

        public void SayName()
        {
            Console.WriteLine("Name :  " + FirstName + " " + LastName);
        }



    }
}