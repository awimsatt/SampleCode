using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMania
{
	public class DeckOfCards
	{
		private const int DECKSIZE = 52;

		private List<Card> _deck;

		public List<Card> Deck
		{
			get { return _deck; }
			set { _deck = value; }
		}

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

		public bool shuffle(int numRepeat)
		{
			if (Deck.Count == DECKSIZE)
			{
				int splitDeck = Deck.Count / 2;
				for (int i = 0; i < numRepeat; i++)
				{
					Random r = new Random(DateTime.Now.Millisecond);
					for(int j = 0; j < splitDeck; j++ )
					{
						int a = r.Next(DECKSIZE - 1);
						int b = r.Next(DECKSIZE - 1);
						Card tempCard = Deck[a];
						Deck[b] = Deck[a];
						Deck[a] = tempCard;
					}
				}
			}
			else
			{
				// Deck is not full, shuffle not allowed
				return false;
			}
			return true;
		}

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

		public void printDeck()
		{
			foreach (Card c in Deck)
			{
				Console.WriteLine( c.Value.ToString() + " of " + c.Suit.ToString());
			}
		}		
	}
}
