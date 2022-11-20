namespace CoonCan;
using System.Linq;

class Program
{
	 static CardsFactory cardsFactory = new CardsFactory();

	 static void Main(string[] args)
	{
		string Ground = "";
		Deck deck = cardsFactory.GenerateShuffledDeck();
		List <Card> cards = deck.ListOfCards;
		List<Card> hand = cardsFactory.GenerateHand(deck);
		Player player = new Player();
		player.Name = "Tarek";
		player.Score = 300;
		// player.Hand.Add(cards[0]);
		Console.WriteLine(hand.Count);
		Console.WriteLine(deck);
		Console.WriteLine(player);
		


	}
}