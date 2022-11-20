namespace CoonCan;

public class Deck
{
	public List<Card> ListOfCards { get; set; }

	public Deck(List<Card> listOfCards)
	{
		ListOfCards = listOfCards;
	}

	public override string ToString()
	{
		string cards = "";
		foreach (var card in ListOfCards)
		{
			cards += card + ", ";
		}

		return cards;
	}
}