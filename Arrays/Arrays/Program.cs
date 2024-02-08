using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // This is the short way to write out an array//
        string[] numArray = new string[] { "hello" , "what", "is", "your", "name" };
        //string[] numArray = new string[5];
        //numArray[0] = "hello";
        //numArray[1] = "What";
        //numArray[2] = "is";
        //numArray[3] = "your";
        //numArray[4] = "name";

        Console.WriteLine("select one index from the array 0 - 4: ");
        int indexSelect1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(numArray[indexSelect1]);


        

        

        Console.ReadLine();

        //Selecting from array with intergers//
        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        Console.WriteLine("select one index from the array 0 - 6: ");
        int indexSelect2 = Convert.ToInt32(Console.ReadLine());
        if (indexSelect2 > 0 && indexSelect2 < numArray1.Length)
        {
            Console.WriteLine(numArray1[indexSelect2]);
        }
        else
        {
            Console.WriteLine("index is out of range");
        }
        Console.ReadLine();

        List<string> intList = new List<string>();
        intList.Add("Dog");
        intList.Add("Cat");
        intList.Add("Bird");
        //Selecting from a list
        Console.WriteLine("select one index from the list 0-2 ");
        int indexSelect3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(intList[indexSelect3]);

        Console.ReadLine();



        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };


        //numArray2[5] = 650;

        //Console.WriteLine("This is the index" + " " + numArray1[0] + numArray[1] + " " + numArray[2] + " " + numArray[3] + " " + numArray[4]);

        //Console.WriteLine("select an index");

        //string awnser = Console.ReadLine();
        //Console.WriteLine("You picked " + awnser );

        //if ( numArray[0] < numArray[1]   )
        //{
        //     Console.WriteLine("This Index does not exist");
        //}




        //byte[] byteArray = new byte[5000];

    }
}

