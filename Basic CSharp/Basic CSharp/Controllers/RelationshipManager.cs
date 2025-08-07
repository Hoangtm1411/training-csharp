using Basic_CSharp.Models;

public class RelationshipManager
{
	private readonly Dictionary<(string, string), int> _relationships = new();

	public void AddRelationship(Character from, Character to, int charisma)
	{
		_relationships[(from.Name, to.Name)] = charisma;
	}

	public void RemoveRelationship(string from, string to)
	{
		_relationships.Remove((from, to));
	}

	public int GetRelationship(string from, string to)
	{
		return _relationships.TryGetValue((from, to), out var value) ? value : 0;
	}

	public void PrintAllRelationships()
	{
		foreach (var kvp in _relationships)
			Console.WriteLine($"{kvp.Key.Item1} → {kvp.Key.Item2}: Charisma = {kvp.Value}");
	}
}
