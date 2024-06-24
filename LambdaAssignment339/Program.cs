using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAssignment339
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            List<Employee> employeelist = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Joe", LastName = "Schmo" },
                new Employee() { Id = 2, FirstName = "sam", LastName = "Schmo" },
                new Employee() { Id = 3, FirstName = "Dan", LastName = "Schmo" },
                new Employee() { Id = 4, FirstName = "Gabe", LastName = "Schmo" },
                new Employee() { Id = 5, FirstName = "Nick", LastName = "Schmo" },
                new Employee() { Id = 6, FirstName = "Joe", LastName = "Schmo" },
                new Employee() { Id = 7, FirstName = "Kevin", LastName = "Schmo" },
                new Employee() { Id = 8, FirstName = "Val", LastName = "Schmo" },
                new Employee() { Id = 9, FirstName = "Caral", LastName = "Schmo" },
                new Employee() { Id = 10, FirstName = "Emily", LastName = "Schmo" },
            };
            List<Employee> joeList = new List<Employee>();
            foreach (var item in employeelist)
            {
                if (item.FirstName == "Joe")
                {
                    joeList.Add(item);
                }
            }
            foreach (var item in joeList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Id);
            }
            List<Employee> joeList2 = employeelist.Where(x => x.FirstName == "Joe").ToList();
            foreach (var item in joeList2)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Id);
            }

            List<Employee> newList = employeelist.Where(x => x.Id > 5).ToList();

            foreach (var item in newList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Id);
            }

            
         

            

        }
    }
}

