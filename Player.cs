namespace CoonCan;

public class Player
{
	public string Name { get; set; }
	public int Score { get; set; }
	public List<Card> Hand { get; set; }
	public List<List<string>> Sets { get; set; }

	public override string ToString()
	{
		string player = $"Name: {Name}, Score: {Score}";
		return player;
	}
}