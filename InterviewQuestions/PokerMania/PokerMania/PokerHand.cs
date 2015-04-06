using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMania
{
	/// <summary>
	/// PokerHand class manages a list of Card objects.
	/// </summary>
	public class PokerHand
	{
		private const int HANDSIZE = 5;
		private List<Card> _hand;

		/// <summary>
		/// Hand contains a list of HANDSIZE cards
		/// </summary>
		public List<Card> Hand
		{
			get { return _hand; }
			set { _hand = value; }
		}

		/// <summary>
		/// PokerHand Constructor
		/// </summary>
		public PokerHand()
		{
			Hand = new List<Card>();
		}

		/// <summary>
		/// Adds a single card to the PokerHand.  
		/// </summary>
		/// <param name="newCard"></param>
		/// <returns>true if card was added successfully and false if the hand is too full to accept another card</returns>
		public bool addCard(Card newCard)
		{
			if ( Hand.Count < HANDSIZE )
			{
				Hand.Add(newCard);
			}
			else
			{
				// Hand is full, no more cards can be added
				return false;
			}

			return true;
		}

		/// <summary>
		/// Prints the hand of cards
		/// </summary>
		public void printHand()
		{
			StringBuilder sb = new StringBuilder();
			
			foreach(Card c in Hand)
			{
				sb.Append(c.Value.ToString());
				sb.Append(" of ");
				sb.Append(c.Suit.ToString());
				sb.Append(" - ");
			}

			string output = sb.ToString();
			// remove extra dash from the output
			output = output.Substring(0, output.Length - 3);

			Console.WriteLine(output + "\n");
		}
		
	}
}
