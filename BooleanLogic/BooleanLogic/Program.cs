using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int person1Age = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? (True or False)");
            bool answer = Convert.ToBoolean( Console.ReadLine().ToLower());


            Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int person1St = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Qualified?");

            Console.WriteLine(person1Age > 15 && !answer && person1St < 4);
            

            //int Q1pass = person1Age;
            //int Q2pass = answer;
            //int Q3pass = person1St;

            //bool speedingTic = (person1St < 3);
            //bool ofAge = (person1Age >= 16);
            //bool noDUI = (answer);

            
            Console.WriteLine();


















































            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);


            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);


            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

            //Console.ReadLine();




        }
    }
}
