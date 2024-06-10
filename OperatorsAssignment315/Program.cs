using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment315
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { Id = 1 };
            Staff staff = new Staff() { Id = 2 };
            Console.WriteLine(employee == staff);
            Console.WriteLine(employee != staff);
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