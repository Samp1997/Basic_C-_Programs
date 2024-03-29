using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, };
            Console.WriteLine("select a number from the List to divide  ");
            int userimput = Convert.ToInt32(Console.ReadLine());



            try
                {
                
                
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(numberList.Count);
                Console.WriteLine("Divinding the two...");
                int numberThree = userimput / numberTwo;
                Console.WriteLine(userimput + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number. ");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont devide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();

            /// for (int i = 0; i < numberlist.count; i++)
            // {
            //     if (numberlist[i] == userimput)
            //     {
            //         console.writeline("selected number:  " + numberlist[i] + " at index " + i);
            //     }
            //     else if (!numberlist.contains(userimput))
            //     {
            //         console.writeline("item not found");
            //         break;
            //     }//

        }
    }
}
