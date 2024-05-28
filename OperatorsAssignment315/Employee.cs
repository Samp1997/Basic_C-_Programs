using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment315
{
    public class Employee
    {
        public List<Employee> Employees { get; set; }
        public int FirstName { get; set; }

        public string LastName { get; set; }

        public bool id { get; set; }



        public static Employee operator+ (Employee employee, Staff staff)
        {
            staff.Employee.Add(employee);
            return staff;
        }
        public static Employee operator +(Employee employee, Staff staff)
        {
            staff.Employee.Remove(employee);
            return staff;
        }


    }
}
