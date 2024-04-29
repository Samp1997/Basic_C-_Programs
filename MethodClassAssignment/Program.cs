using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps Obj1 = new MathOps();
            

            Console.WriteLine("Enter a number, two numbers will be auto generated)");

            int num1 = Convert.ToInt32(Console.ReadLine());
            string answer = Console.ReadLine();
            

            if (answer == "")
            {
                int finalawnser = Obj1.Math1(num1);
                Console.WriteLine(finalawnser);
            }
            else
            {
                int num2 = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
