namespace CoonCan;

public class CardsFactory
{
	//Playing cards ranks and suits.
	private readonly int[] _ranks = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
	private readonly string[] _suits = { "H", "D", "C", "S"};
	const int NumberOfDecks = 2;
	const int NumberOfJokers = 2;
	const int NumberOfCardPerHand = 14;
	


	//Iterates through the ranks and suits lists, to generate all of the cards and add them to a list.
	//Then returns a shuffled deck.
	public Deck GenerateShuffledDeck()
	{
		List<Card> listOfCards = new List<Card>();

		for (int i = 0; i < NumberOfDecks; i++)
		{
			foreach (var suit in _suits)
			{
				foreach (var rank in _ranks)
				{
					listOfCards.Add(new Card(rank, suit));
				}
			}
		}
		
		for (int i = 0; i < NumberOfJokers; i++)
		{
			listOfCards.Add(new Card(14, "JK"));
		}
		
		Random random = new Random();
		listOfCards  = listOfCards.OrderBy(_ => random.Next()).ToList();

		return new Deck(listOfCards);
	}
	
	
	// Generates a list of N number of cards from a shuffledDeck then remove the cards from shuffled deck.
	public List<Card> GenerateHand(Deck deck)
	{
		List<Card> hand = new List<Card>(deck.ListOfCards.Take(NumberOfCardPerHand));
		deck.ListOfCards.RemoveRange(0, NumberOfCardPerHand);
		return hand;
	}
	//
	// //Generates a list of hands.
	// public List<List<string>> GenerateAllHands()
	// {
	// 	//Generate shuffled deck
	// 	List<string> shuffledDeck = GenerateShuffledDeck();
	// 	
	// 	List<List<string>> allHands = new List<List<string>>();
	// 	
	// 	for (int i = 0; i < NumberOfHands; i++)
	// 	{
	// 		allHands.Add(new List<string>(GenerateHand()));
	// 	}
	// 	return allHands;
	// }
	//
	// //Draw a card.
	// public void DrawCard(List<string> hand, List<string> shuffledDeck)
	// {
	// 	var card = shuffledDeck[0];
	// 	hand.Add(card);
	// 	shuffledDeck.RemoveAt(0);
	//
	// }
	//
	// public List<string> CreateSet(params string[] cards)
	// {
	// 	List<string> set = new List<string>();
	// 	foreach (var card in cards)
	// 	{
	// 		set.Add(card);
	// 	}
	//
	// 	return set;
	// }
	
}