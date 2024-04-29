using System;

namespace MethodSubmissionAssignment281
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps Obj1 = new MathOps();

            int answer = Obj1.Math1(6);
            int answer2 = Obj1.Math1(43);
            int answer3 = Obj1.Math1(9);

            Console.WriteLine("input two numbers, one at a time, (one input one nummber)");
            Console.ReadLine();
            Console.WriteLine();
        }


    }
}
