using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMania
{
	public class PokerHand
	{

		private const int HANDSIZE = 5;
		private List<Card> _hand;

		public List<Card> Hand
		{
			get { return _hand; }
			set { _hand = value; }
		}

		public PokerHand()
		{
			Hand = new List<Card>();
		}

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
			output = output.Substring(0, output.Length - 4);

			Console.WriteLine(output + "\n");
		}
		
	}
}
