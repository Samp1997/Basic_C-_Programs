using System;

namespace PolymorphismAssignment307
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable Obj1 = new Employee() { FirstName = "Sample", LastName = "Student", id = 5 };
            Obj1.Quit();

        }
    }
}
