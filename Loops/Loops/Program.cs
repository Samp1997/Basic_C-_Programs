using System;


namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            while (isGuessed)
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guess 62. Try again.");
                        break;
                    case 29:
                        Console.WriteLine("You guess 29. Try again.");
                        break;
                    case 55:
                        Console.WriteLine("You guess 55. Try again.");
                        break;
                    case 12:
                        Console.WriteLine("You guess 12. Thats Correct!");
                        break;
                    default:
                        Console.WriteLine("You are Wrong");
                        break;


                }
                
                    Console.ReadLine();
            }
        }


    }
}
