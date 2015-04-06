using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMania
{
	/// <summary>
	/// DeckOfCards class contains methods for managing a deck of 52 cards.
	/// </summary>
	public class DeckOfCards
	{
		private const int DECKSIZE = 52;

		private List<Card> _deck;
		/// <summary>
		/// The deck of cards
		/// </summary>
		public List<Card> Deck
		{
			get { return _deck; }
			set { _deck = value; }
		}

		/// <summary>
		/// Constructor initializes the deck of cards ordered by suit and value
		/// </summary>
		public DeckOfCards()
		{
			// Initialize the deck
			Deck = new List<Card>();
			foreach (CardSuits suit in Enum.GetValues(typeof(CardSuits)))
			{
				foreach (CardValues value in Enum.GetValues(typeof(CardValues)))
				{
					Card newCard = new Card();
					newCard.Suit = suit;
					newCard.Value = value;

					Deck.Add(newCard);
				}
			}
		}

		/// <summary>
		/// Shuffles the deck of cards the number of times specified by numRepeat. The numRepeat parameter must be greater than 0.
		/// </summary>
		/// <param name="numRepeat"></param>
		/// <returns>true if shuffle was successful and false if there was problem</returns>
		public bool shuffle(int numRepeat)
		{
			if (Deck.Count == DECKSIZE && numRepeat > 0)
			{
				// split the deck in half just like a person would if shuffling physical cards by hand.
				int splitDeck = Deck.Count / 2;
				for (int i = 0; i < numRepeat; i++)
				{
					Random r = new Random(DateTime.Now.Millisecond);
					for(int j = 0; j < splitDeck; j++ )
					{
						int a = r.Next(DECKSIZE - 1);
						int b = r.Next(DECKSIZE - 1);
						Card tempCard = Deck[a];
						Deck[a] = Deck[b];
						Deck[b] = tempCard;
					}
				}
			}
			else
			{
				// Deck is not full or numRepeat was not greater than 0, shuffle not allowed
				return false;
			}
			return true;
		}

		/// <summary>
		/// Returns the top card of the deck and removes it from the deck
		/// </summary>
		/// <returns>The top card of the deck</returns>
		public Card getTopCard()
		{
			Card topCard = new Card();
			if (Deck.Count > 0)
			{
				topCard = Deck[0];
				Deck.Remove(topCard);
			}
			else
			{
				// Deck has no more cards.
				return null;
			}

			return topCard;
		}

		/// <summary>
		/// Resets the deck back to its initial state of ordered cards by suit and value
		/// </summary>
		public void resetDeck()
		{
			Deck.Clear();
			foreach (CardSuits suit in Enum.GetValues(typeof(CardSuits)))
			{
				foreach (CardValues value in Enum.GetValues(typeof(CardValues)))
				{
					Card newCard = new Card();
					newCard.Suit = suit;
					newCard.Value = value;

					Deck.Add(newCard);
				}
			}
		}

		/// <summary>
		/// Prints the deck of cards to the Console
		/// </summary>
		public void printDeck()
		{
			foreach (Card c in Deck)
			{
				Console.WriteLine( c.Value.ToString() + " of " + c.Suit.ToString());
			}
		}		
	}
}
