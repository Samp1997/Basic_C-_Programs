using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;

            Console.WriteLine(card1.Face);

            //Deck deck = new Deck();
            //deck.Shuffle(3);


            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();


        }
        

       
        
     
    }
}


//public static Deck Shuffle(Deck, int times)
//{
//    for (int i = 0; i < times; i++)
//    {
//        deck = Shuffle(deck);
//    }
//    return deck;
//}

//Games games = new TwentyOneGame();
//games.Players = new List<Player>();
//Player player = new Player();
//player.Name = "sam";
//games += player;
//games -= player;

//Console.WriteLine(deck.Cards[01].Face + " of " + deck.Cards[0].Suit);
//Console.ReadLine();

//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";

//deck.Cards.Add(cardOne);



//Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);