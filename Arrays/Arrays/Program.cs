using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] =200;
        numArray[4] = 5000;

        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };


        numArray2[5] = 650;

        Console.WriteLine("select an index");
        int awnser = numArray1[0];
        Console.WriteLine("You picked " + awnser);

        Console.WriteLine(numArray2[5]);
        Console.ReadLine();


        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Sam");
        intList.Remove("Sam");

        Console.WriteLine();

        byte[] byteArray = new byte[5000];

    }
}

