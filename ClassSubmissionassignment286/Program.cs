using System;

namespace ClassSubmissionassignment286
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates an object
            MathOps Obj1 = new MathOps();
            // asking the user to imput a number
            Console.WriteLine("Input a number");
            // Converting a user imput to a interger 
            int userimput = Convert.ToInt32(Console.ReadLine());
            //Calling the method 
            Obj1.Math1(userimput);
            int output1;
            Obj1.Math1(userimput, out output1);
            Console.WriteLine(output1);
            // takes the resluts and displays 5
            int result = StaticClass.Math2("5");
            Console.WriteLine(result);
            Console.ReadLine();



        }
    }
}
