namespace CoonCan;
using System.Linq;

class Program
{
	 static CardsFactory cardsFactory = new CardsFactory();

	 static void Main(string[] args)
	 {
		 Game game = new Game
		 {
			 deck = cardsFactory.GenerateShuffledDeck()
		 };
		 
		 List<Player> players = new List<Player>
		 {
			 new Player { Name = "Tarek" },
			 new Player { Name = "Dana" }
		 };

		 game.players = players;

		 Console.WriteLine("Over");
	 }
}