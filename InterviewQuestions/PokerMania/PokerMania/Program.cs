using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMania
{
	class Program
	{
		static void Main(string[] args)
		{
			Dealer dealer = new Dealer();

			List<PokerHand> hands = new List<PokerHand>();

			int NumberOfHands = 5;
			hands = dealer.dealHands(NumberOfHands);

			for(int i = 0; i < hands.Count; i++)
			{
				Console.WriteLine("Hand #" + (i + 1).ToString());
				hands[i].printHand();
			}
		}
	}
}
