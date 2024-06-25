using System;

namespace DateTimeAssignment371
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(input));
            

            
        }
    }
}
