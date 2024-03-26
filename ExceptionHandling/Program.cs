using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> intList = new List<string>();
            intList.Add("1");
            intList.Add("2");
            intList.Add("3");
            intList.Add("4");
            intList.Add("5");
            //Selecting from a list
            Console.WriteLine("select a number from the List to divide  ");
            float userimput = float.Parse(Console.ReadLine());

         
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == userimput)
                {
                    Console.WriteLine("Selected Player:  " + intList[i] + " at index " + i);
                }
                else if (!intList.Contains(userimput))
                {
                    Console.WriteLine("Item not found");
                    break;
                }




                try
                {
                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Divinding the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
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

            
            
        }
    }
}
