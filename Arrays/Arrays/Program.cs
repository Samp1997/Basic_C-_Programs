using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Sam");
        intList.Remove("Sam");

        Console.WriteLine(intList[0]);

    }
}

