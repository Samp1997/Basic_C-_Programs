using System;
using System.Collections.Generic;

namespace sixpartassignment
{
    class Program
    {
        static void Main()
        {
            //Part 1//
            string[] playerArray = new string[] { "Player 1", "Player 2", "Player 3", "Player 4"};

            Console.WriteLine("Please enter word ");
            string PlayerSelect1 = Console.ReadLine();
            for (int i = 0; i < playerArray.Length; i++)
            {
                playerArray[i] = PlayerSelect1 + playerArray[i];
            }
            foreach(string Player in playerArray)
            {
                Console.WriteLine(Player);
            }  

            Console.ReadLine();
            
            //part 4
            List<string> intList = new List<string>();
            intList.Add("Player 5");
            intList.Add("Player 6");
            intList.Add("Player 7");
            //Selecting from a list
            Console.WriteLine("select a player from the List  ");
            string PlayerSelect2 = (Console.ReadLine());

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == PlayerSelect2)
                {
                    Console.WriteLine("Selected Player:  " + intList[i] + " at index " + i);
                }
                else if (!intList.Contains(PlayerSelect2))
                {
                    Console.WriteLine("Item not found");
                    break;
                }

            }

            //part 5



            List<string> intList2 = new List<string>();
            intList2.Add("Player 5");
            intList2.Add("Player 6");
            intList2.Add("Player 7");
            //Selecting from a list
            Console.WriteLine("select a player from the List  ");
            string PlayerSelect3 = (Console.ReadLine());

            for (int i = 0; i < intList2.Count; i++)
            {
                if (intList2[i] == PlayerSelect3)
                {
                    Console.WriteLine("Selected Player:  " + intList2[i] + " at index " + i);
                }
                else if (!intList2.Contains(PlayerSelect3))
                {
                    Console.WriteLine("Item not found");
                    break;
                }

            }

            List<int> gamePoints = new List<int>() { 1, 2, 3, 4, 5, 6, 6 };
            List<int> gamePoints2 = new List<int>() { };
            foreach(int i in gamePoints )
            
            {
                if (gamePoints2.Contains(i))
                {
                    Console.WriteLine("This item is a double");
                }
                else
                {
                  
                    Console.WriteLine("This is unique ");
                    gamePoints2.Add(i);
                }
            }

        }

    }
}
