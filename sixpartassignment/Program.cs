using System;

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
            // push/pull test
            List<string> intList = new List<string>();
            intList.Add("Player 2");
            intList.Add("Player 3");
            intList.Add("Player 4");
            //Selecting from a list
            Console.WriteLine("select a player from the List 0 - 2 ");
            int PlayerSelect2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intList[PlayerSelect2]);

            for (int i = 0; i < intList.Length; i++)
            {
               intList[i] += PlayerSelect2;
            }

            if (PlayerSelect2 <= playerArray.Length)
            {
                Console.WriteLine(PlayerSelect1 + "  Player cant be selected");
            }






        }

    }
}
