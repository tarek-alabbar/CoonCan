namespace CoonCan;
using System.Linq;

class Program
{
	 static CardsFactory cardsFactory = new CardsFactory();
	static string PrintHand(List<string> hand)
	{
		string cards = "";
		// Console.Write("Hand: ");
		foreach (var card in hand)
		{
			cards += card + "\t";
		}

		return cards;
	}

	static void PrintShuffledDeck()
	{
		Console.WriteLine("ShuffledDeck Size= " + cardsFactory.ShuffledDeck.Count);
		Console.WriteLine("Ground card is: " + cardsFactory.Ground);
		// foreach (var card in cardsFactory.ShuffledDeck)
		// {
		// 	Console.Write(card + "\t");
		// }
		
	}
	static void Main(string[] args)
	{

		//Call a method to generate all of hands
		List<List<string>> allHands = cardsFactory.GenerateAllHands();

		//Debugging
		// foreach (var hand in allHands)
		// {
		// 	PrintHand(hand);
		// }
		//
		// PrintShuffledDeck();
		//
		// foreach (var hand in allHands)
		// {
		// 	cardsFactory.DrawCard(hand, cardsFactory.ShuffledDeck);
		// }
		//
		// foreach (var hand in allHands)
		// {
		// 	PrintHand(hand);
		// }
		//
		// PrintShuffledDeck();

		for (int i = 0; i < 4; i++)
		{ 
			Console.WriteLine("(Before draw card) Player{0}: {1}", i+1, PrintHand(allHands[i]));
			cardsFactory.DrawCard(allHands[i], cardsFactory.ShuffledDeck);
			Console.WriteLine("(After draw card) Player{0}: {1}", i+1, PrintHand(allHands[i]));
			Console.Write("Play a card:");
			var userInput = Console.ReadLine();
			allHands[i].Remove(userInput);
			cardsFactory.Ground = userInput;
			Console.WriteLine("Player{0}: {1}", i+1, PrintHand(allHands[i]));
			PrintShuffledDeck();
		}
	}
}