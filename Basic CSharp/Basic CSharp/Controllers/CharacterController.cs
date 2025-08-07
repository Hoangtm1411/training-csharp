using Basic_CSharp.Models;
using Basic_CSharp.Models.Emotions;
using Basic_CSharp.Models.Equipment;

public class CharacterController
{
	private Character _character;

	public CharacterController(Character character)
	{
		_character = character;
	}

	public Character GetCharacter() => _character;

	public void SetEmotion(IEmotionState emotion)
	{
		_character.ChangeEmotion(emotion);
	}

	public void EquipItem(IEquipment item)
	{
		_character.Equip(item);
	}

	public void RemoveItem(string equipmentName)
	{
		var item = _character.Equipments.FirstOrDefault(e => e.Name == equipmentName);
		if (item != null)
		{
			_character.Equipments.Remove(item);
		}
	}

	public void ListEquipment()
	{
		Console.WriteLine($"[Equipments of {_character.Name}]");
		foreach (var eq in _character.Equipments)
			Console.WriteLine($"- {eq.Name}");
	}

	public Stats ShowStats()
	{
		var stats = _character.GetCurrentStats();
		Console.WriteLine($"Stats of {_character.Name}: HP={stats.HP}, Energy={stats.Energy}, Lucky={stats.LuckyPoint}, Charisma={stats.Charisma}");
		return stats;
	}
}
