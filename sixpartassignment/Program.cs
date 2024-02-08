using System;
using System.Collections.Generic;

namespace sixpartassignment
{
    class Program
    {
        static void Main()
        {
            string[] playerArray = new string[] { "Player 1", "Player 2", "Player 3", "Player 4"};

            Console.WriteLine("select a player from the array 0 - 3: ");
            int PlayerSelect1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(playerArray[PlayerSelect1] + " Selected");

            Console.ReadLine();

            Console.WriteLine(playerArray[PlayerSelect1]);
            Console.ReadLine();

            for(int i = 0; i < playerArray.Length;i++){
               playerArray[i] += PlayerSelect1;
            }

            for (int i = 0; i < playerArray.Length; i++)
            {
                Console.WriteLine(playerArray[i]);
            }

            //git changes
            
            if (PlayerSelect1 >  playerArray.Length)
            {
                Console.WriteLine(playerArray[PlayerSelect1]);
            }

            if (PlayerSelect1 < playerArray.Length)
            {
                Console.WriteLine(playerArray[PlayerSelect1]);
            }

            if (PlayerSelect1 <= playerArray.Length)
            {
                Console.WriteLine(PlayerSelect1 + "  Player cant be selected");
            }
            Console.WriteLine();
            

            bool hasToend = true;
            // using while loop
            while (hasToend)
            {

                
                // infinite 
                Console.WriteLine("Lets play");
                hasToend = false;
                //Changing the var ends the loop//

            }
            Console.ReadLine();
            
            List<string> intList = new List<string>();
            intList.Add("Player 5");
            intList.Add("Player 6");
            intList.Add("Player 7");
            //Selecting from a list
            Console.WriteLine("select a player from the List  ");
            string PlayerSelect2 = (Console.ReadLine());
            

            bool found = false;
            for (int i = 0; i < intList.Count; i++)
            {
               if (intList[i] == PlayerSelect2)
                {
                    found = true;
                    Console.WriteLine("the index is ", i);
                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine("Selection isnt on the list");

            }



            List<string> intList2 = new List<string>();
            intList2.Add("Player 5");
            intList2.Add("Player 5");
            intList2.Add("Player 7");
            //Selecting from a list
            Console.WriteLine("select a player from the List  ");
            string PlayerSelect3 = (Console.ReadLine());

            bool found2 = false;
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == PlayerSelect2)
                {
                    found = true;
                    Console.WriteLine("the index is ", i);
                    break;
                }
            }

            if (found2 == false)
            {
                Console.WriteLine("Selection isnt on the list");

            }



        }

    }
}
