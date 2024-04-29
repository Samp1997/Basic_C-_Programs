using System;

namespace MethodSubmissionAssignment281
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps Obj1 = new MathOps();

            

            Console.WriteLine("input two numbers, one at a time, (input one nummber the other will be auto generated)");

            
            int num1 = Convert.ToInt32(Console.ReadLine());
            string answer2 = Console.ReadLine();

            if (answer2 == "") 
            {
                
                int finalawnser = Obj1.Math1(num1);
                Console.WriteLine(finalawnser);
            }
            else
            {
                int num2 = Convert.ToInt32(answer2); 
                int finalawnser = Obj1.Math1(num1, num2);
                Console.WriteLine(finalawnser);
            }

            

            
            
        }


    }
}
