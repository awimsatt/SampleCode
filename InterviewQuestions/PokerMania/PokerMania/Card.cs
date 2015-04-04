using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMania
{
	public enum CardSuits
	{
		Spades,
		Hearts,
		Clubs,
		Diamonds
	}

	public enum CardValues
	{
		King = 14,
		Queen = 13,
		Jack = 12,
		Ten = 11,
		Nine = 10,
		Eight = 9,
		Seven = 8,
		Six = 7,
		Five = 5,
		Four = 4,
		Three = 3,
		Two = 2,
		Ace = 1
	}

	/// <summary>
	/// Card class defines a card with a suit and a value
	/// </summary>
	public class Card
	{
		/// <summary>
		/// The Card Suit
		/// </summary>
		private CardSuits _suit;
		public CardSuits Suit
		{
			get { return _suit; }
			set { _suit = value; }
		}

		/// <summary>
		/// The Card Value
		/// </summary>
		private CardValues _value;
		public CardValues Value
		{
			get { return _value; }
			set { _value = value; }
		}
	}
}
