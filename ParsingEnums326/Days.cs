using System;
using System.Collections.Generic;
using System.Text;

namespace ParsingEnums326
{
    class Days
    {
        public WeekDays weekDays { get; set; }
        public Weekends Weekends { get; set; }
    }
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
        
    }

    public enum Weekends
    {
        Saturday,
        Sunday
    }
}
