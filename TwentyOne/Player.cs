using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Games operator+ (Games games, Player player)
        {
            games.Players.Add(player);
            return games;
        }

        public static Games operator- (Games games, Player player)
        {
            games.Players.Remove(player);
            return games;
        }


    }
}
