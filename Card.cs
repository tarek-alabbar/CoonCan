namespace CoonCan;

public class Card
{
	public int Rank { get; set; }
	public string Suit { get; set; }

	public Card(int rank, string suit)
	{
		Rank = rank;
		Suit = suit;
	}
	
	public override string ToString()
	{
		return Rank + Suit;
	}
}