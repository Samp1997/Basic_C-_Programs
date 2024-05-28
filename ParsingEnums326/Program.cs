using System;

namespace ParsingEnums326
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the day of the week");
                WeekDays day = (WeekDays)Enum.Parse(typeof(WeekDays), Console.ReadLine());
                Console.WriteLine("Have a nice " + day);
                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Enter The actual day of the week");
            }
        }

        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday

        }
    }
}
