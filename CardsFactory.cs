namespace CoonCan;

public class CardsFactory
{
	//TODO: Card should be an object or model.
	//TODO: 2 classes: card class and deck class.
	
	//Playing cards ranks and suits.
	private readonly string[] _ranks = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
	private readonly string[] _suits = { "H", "D", "C", "S"};
	const int NumberOfDecks = 2;
	const int NumberOfJokers = 2;
	const int NumberOfHands = 4;
	const int NumberOfCardPerHand = 14;
	public List<string> ShuffledDeck = new List<string>();
	public string Ground = "";


	//Iterates through the ranks and suits lists, to generate all of the cards and add them to a list.
	//Then returns a shuffled deck.
	public List<string> GenerateShuffledDeck()
	{
		// List<string> deck = new List<string>();

		for (int i = 0; i < NumberOfDecks; i++)
		{
			foreach (var suit in _suits)
			{
				foreach (var rank in _ranks)
				{
					ShuffledDeck.Add(rank + suit);
				}
			}
		}
		
		for (int i = 0; i < NumberOfJokers; i++)
		{
			ShuffledDeck.Add("JK");
		}
		
		Random random = new Random();
		ShuffledDeck  = ShuffledDeck.OrderBy(_ => random.Next()).ToList();
		return ShuffledDeck;
	}
	
	
	// Generates a list of N number of cards from a shuffledDeck then remove the cards from shuffled deck.
	public List<string> GenerateHand()
	{
		var hand = new List<string>(ShuffledDeck.Take(NumberOfCardPerHand));
		ShuffledDeck.RemoveRange(0, NumberOfCardPerHand);
		return hand;
	}

	//Generates a list of hands.
	public List<List<string>> GenerateAllHands()
	{
		//Generate shuffled deck
		List<string> shuffledDeck = GenerateShuffledDeck();
		
		List<List<string>> allHands = new List<List<string>>();
		
		for (int i = 0; i < NumberOfHands; i++)
		{
			allHands.Add(new List<string>(GenerateHand()));
		}
		return allHands;
	}

	//Draw a card.
	public void DrawCard(List<string> hand, List<string> shuffledDeck)
	{
		var card = shuffledDeck[0];
		hand.Add(card);
		shuffledDeck.RemoveAt(0);

	}
	
}