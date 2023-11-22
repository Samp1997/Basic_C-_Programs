using System;


namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i < 3)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guess 62. Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guess 29. Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guess 55. Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guess 12. Thats Correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are Wrong");
                        Console.WriteLine("Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;


                }
            }

            while (!isGuessed);

            Console.Read();
            
                    
            
        }


    }
}
