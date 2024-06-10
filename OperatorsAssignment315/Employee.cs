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
        

        public bool Id { get; set; }




       


    }

    public class Staff
    {
        public List<Staff> Saffs { get; set; }
        public int FirstName { get; set; }

        public string LastName { get; set; }


        public bool Id { get; set; }


        public static bool operator ==(Employee employee, Staff staff)
        {
            return employee.Id == staff.Id;
        }
        public static bool operator !=(Staff staff, Employee employee)
        {
            return employee.Id != staff.Id;
        }

    }

   



}

