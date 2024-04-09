using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            //Taking each int and applying to the methods
            Console.WriteLine(MathOperations.Math1(number));
            Console.ReadLine();

            Console.WriteLine(MathOperations.Math2(number2));
            Console.ReadLine();

            Console.WriteLine(MathOperations.Math3(number.ToString(number3));
            Console.ReadLine();

        }
    }
}
