using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps Obj1 = new MathOps();
            
            
            
            int num1 = Convert.ToInt32(Console.ReadLine());
            int finalawnser = Obj1.Math1(num1);
        }
    }
}
