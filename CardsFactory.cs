namespace CoonCan;

public class CardsFactory
{
	//Playing cards ranks and suits.
	private readonly string[] _ranks = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
	private readonly string[] _suits = { "Spades", "Hearts", "Clubs", "Diamonds"};

	
	//Iterates through the ranks and suits lists, to generate all of the cards and add them to a list.
	//Then returns a shuffled deck.
	public List<string> GenerateShuffledDeck(int numberOfDecks, int numberOfJokers)
	{
		List<string> deck = new List<string>();

		for (int i = 0; i < numberOfDecks; i++)
		{
			foreach (var suit in _suits)
			{
				foreach (var rank in _ranks)
				{
					deck.Add(rank + "-" + suit);
				}
			}
		}
		
		for (int i = 0; i < numberOfJokers; i++)
		{
			deck.Add("JK");
		}
		
		Random random = new Random();
		deck  = deck.OrderBy(_ => random.Next()).ToList();
		return deck;
	}
	
	
	// Generates a list of N number of cards from a shuffledDeck then remove the cards from shuffled deck.
	public List<string> GenerateHand(List<string> shuffledDeck, int numberOfCardsPerHand)
	{
		var hand = new List<string>(shuffledDeck.Take(numberOfCardsPerHand));
		shuffledDeck.RemoveRange(0, numberOfCardsPerHand);
		return hand;
	}

	//Generates a list of hands.
	public List<List<string>> GenerateAllHands(int numberOfDecks, int numberOfJokers, int numberOfCardPerHand, int numberOfHands)
	{
		//Generate shuffled deck
		List<string> _shuffledDeck = GenerateShuffledDeck(numberOfDecks, numberOfJokers);
		
		List<List<string>> allHands = new List<List<string>>();
		
		for (int i = 0; i < numberOfHands; i++)
		{
			allHands.Add(new List<string>(GenerateHand(_shuffledDeck, numberOfCardPerHand)));
		}
		return allHands;
	}

}