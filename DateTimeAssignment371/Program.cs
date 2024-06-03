using System;

namespace DateTimeAssignment371
{
    class Program
    {
        static void Main(string[] args)
        {


            DateTime currentTime = new DateTime(2024, 6, 2, 10, 02, 00);
            DateTime timePassed = new DateTime(2024, 7, 3, 12, 15, 00);
            Console.WriteLine(currentTime);
            Console.ReadLine();
            Console.WriteLine("Enter a number");
            





            TimeSpan amountOfTime =  currentTime - timePassed;

            Console.WriteLine(amountOfTime);

            
        }
    }
}
