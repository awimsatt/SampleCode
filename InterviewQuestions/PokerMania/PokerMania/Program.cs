using System;
using System.Collections.Generic;
using System.IO;
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

			int NumberOfHands = 0;

			Console.Write("How many Players (Enter a number between 1 - 7)? ");
			TextReader userIn = Console.In;

			String userCount = userIn.ReadLine();

			if (Int32.TryParse(userCount,out NumberOfHands))
			{ 
				hands = dealer.dealHands(NumberOfHands);

				if (hands != null)
				{
					Console.WriteLine("***************************");

					for (int i = 0; i < hands.Count; i++)
					{
						Console.WriteLine("Hand #" + (i + 1).ToString());
						hands[i].printHand();
					}
				}
				else
				{
					// Invalid number of poker hands were requested
					Console.WriteLine("Invalid number of players specified.");
				}
			}
			else
			{
				// User provided invalid input
				Console.WriteLine("Invalid Input.");
			}
		}
	}
}
