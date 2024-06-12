using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment315
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Joe", LastName = "Smith",  Id = 1 };
            Employee employee2 = new Employee() { FirstName = "Jake", LastName = "Adams",  Id = 2 };
            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);
            Console.ReadLine();
        }
    }
}
//Employee employees = new Employee();
//Employee. = new List<Employee>();
//FirstName firstname = new id();
//Employee.Name = "sam";
//games + player;
//games + player;