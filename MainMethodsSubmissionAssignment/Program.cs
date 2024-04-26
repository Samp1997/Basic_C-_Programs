using System;

namespace MainMethodsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations Obj1 = new MathOperations();
            
            int answer = Obj1.Math1(6);
            int answer2 = Obj1.Math1(4.3m);
            int answer3 = Obj1.Math1("9");
            
            //Taking each int and applying to the methods
            Console.WriteLine("result from passing interger variable " +  answer);


            Console.WriteLine("result from passing Decimal variable " + answer2);



            Console.WriteLine("result from passing a String variable " + answer3);
            Console.ReadLine();

            


        }
    }
}
