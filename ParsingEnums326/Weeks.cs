using System;
using System.Collections.Generic;
using System.Text;

namespace ParsingEnums326
{
    class Weeks
    {
        public Weeks()

        {
            Days = new List<Days>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Days day = new Days();
                    days.WeekDays = (WeekDays)j;
                    days.Weekends = (Weekends)i;

                }
            }

            try
            {
                
            }
            catch ()
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
}
