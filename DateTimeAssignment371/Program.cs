using System;

namespace DateTimeAssignment371
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dateTime = new DateTime(2024, 6, 2, 10, 02, 00);
            DateTime currentTime = new DateTime(DateTime.Now);
            DateTime timePassed = new DateTime();
            Console.WriteLine(currentTime);
            Console.ReadLine();
            Console.WriteLine("Enter a number");
            Console.ReadLine();
            Console.WriteLine("How many many hours till your ready?");







            TimeSpan amountOfTime = timePassed - currentTime;

            Console.WriteLine(amountOfTime);

            
        }
    }
}
