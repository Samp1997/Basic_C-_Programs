using System;

namespace MainMethodsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three number");
            int answer = Convert.ToInt32(Console.ReadLine());
            int answer2 = Convert.ToInt32(Console.ReadLine());
            int answer3 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            //Taking each int and applying to the methods
            Console.WriteLine(MathOperations.Math1(answer));
            Console.ReadLine();

            Console.WriteLine(MathOperations.Math2(answer2));
            Console.ReadLine();

            


        }
    }
}
