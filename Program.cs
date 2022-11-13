namespace CoonCan;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		CardsFactory cardsFactory = new CardsFactory();
		int numberOfDecks = 2;
		int numberOfJokers = 2;
		int numberOfHands = 4;
		int numberOfCardPerHand = 14;
	

		//Call a method to generate all of hands
		List<List<string>> allHands =
			cardsFactory.GenerateAllHands(numberOfDecks, numberOfJokers, numberOfCardPerHand, numberOfHands);

		//Debugging
		foreach (var hand in allHands)
		{
			Console.Write("Hand: ");
			foreach (var card in hand)
			{
				Console.Write(card + ", ");
			}
			Console.WriteLine();
		}


	}
}