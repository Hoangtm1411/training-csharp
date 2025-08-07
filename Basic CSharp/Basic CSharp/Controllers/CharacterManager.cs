using Basic_CSharp.Models;

public class CharacterManager
{
	private readonly Dictionary<string, Character> _characters = new();

	public void AddCharacter(Character character)
	{
		if (!_characters.ContainsKey(character.Name))
			_characters.Add(character.Name, character);
	}

	public void RemoveCharacter(string name)
	{
		if (_characters.ContainsKey(name))
			_characters.Remove(name);
	}

	public Character? GetCharacter(string name)
	{
		return _characters.TryGetValue(name, out var character) ? character : null;
	}

	public List<string> ListCharacters()
	{
		return _characters.Keys.ToList();
	}
}
