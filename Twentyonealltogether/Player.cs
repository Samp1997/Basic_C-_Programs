using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twentyonealltogether
{
    public class Player
    {
        public Player (string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public static Game operator +(Game games, Player player)
        {
            games.Players.Add(player);
            return games;
        }

        public static Game operator -(Game games, Player player)
        {
            games.Players.Remove(player);
            return games;
        }


    }
}
