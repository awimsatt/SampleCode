using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMania
{
	public class Dealer
	{
		private const int HANDSIZE = 5;
		private DeckOfCards _deck;

		public DeckOfCards Deck
		{
			get { return _deck; }
			set { _deck = value; }
		}

		public Dealer()
		{
			Deck = new DeckOfCards();
		}

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
