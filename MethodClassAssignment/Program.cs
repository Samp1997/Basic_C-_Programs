using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            MathOps Obj1 = new MathOps();

            


            Console.WriteLine("Input a number");

            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Obj1.Math1(num1, num2);
            Console.ReadLine();
            Obj1.Math1(input1: 8, input2: 12);
            Console.ReadLine();



        }
    }
}
