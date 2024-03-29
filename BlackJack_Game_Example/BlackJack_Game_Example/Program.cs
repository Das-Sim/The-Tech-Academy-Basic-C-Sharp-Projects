﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Game_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome
            Console.WriteLine("Hello and Welcome to the fabulous Dazin Casino! \n Press ENTER to begin playing!!");
            Console.ReadLine();

            Deck deck = new Deck();
            deck = Shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            //deck.Cards = new List<Card>();


            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);


            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            Console.WriteLine(deck.Cards.Count); 
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while(deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;

        }
    }
}
