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

            string problem4 = "adding 5";
            int input3 = Int32.Parse(problem4);
            Console.WriteLine(input3);

            Console.WriteLine(MathOperations.Math3(problem4 + answer3));
            Console.ReadLine();

            


        }
    }
}
