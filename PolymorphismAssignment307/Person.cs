using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAssignment307
{
    class Person
    {
    }
}
class Employee 
{
    public string FirstName;

    public string LastName;

    public int id;

    public void SayName()
    {
        Console.WriteLine("Name :  " + FirstName + " " + LastName);
    }



}
