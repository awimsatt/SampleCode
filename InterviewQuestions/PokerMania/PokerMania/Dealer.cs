using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMania
{
	/// <summary>
	/// Dealer class handles shuffling and dealing cards from a DeckOfCards object
	/// </summary>
	public class Dealer
	{
		private const int HANDSIZE = 5;

		private DeckOfCards _deck;
		/// <summary>
		/// The remaining Deck of cards
		/// </summary>
		public DeckOfCards Deck
		{
			get { return _deck; }
			set { _deck = value; }
		}

		/// <summary>
		/// Dealer Constructor
		/// </summary>
		public Dealer()
		{
			Deck = new DeckOfCards();
		}

		/// <summary>
		/// Shuffles the Deck and returns the number of hands of cards requested
		/// </summary>
		/// <param name="numHands"></param>
		/// <returns>A list of PokerHands or null if there is a problem</returns>
		public List<PokerHand> dealHands(int numHands)
		{
			// Shuffle the deck of cards by the number of players
			Deck.shuffle(numHands);

			List<PokerHand> hands = new List<PokerHand>();
			if (numHands > 0 && numHands < 8)
			{
				for( int i = 0; i < numHands; i++)
				{
					if (hands.Count < numHands)
					{
						hands.Add(new PokerHand());
					}
				}

				for (int j = 0; j < HANDSIZE; j++ )
				{
 					// deal the cards out one card per hand at a time
					foreach (PokerHand pHand in hands)
					{
						pHand.addCard(Deck.getTopCard());
					}
				}
			}
			else
			{
				// Invalid number of hands of poker requested
				return null;
			}

			return hands;
		}		
	}
}
