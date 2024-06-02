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
            
            Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            List<int> numberList = new List<int>() { 1, 2, 3, 535, 686 };

            int sum = numberList.Sum();



           



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


////Card card1 = new Card();
////Card card2 = card1;
////card1.Face = Face.Eight;
////card2.Face = Face.King;

////Console.WriteLine(card1.Face);

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