using Basic_CSharp.Builders;
using Basic_CSharp.Models;
using Basic_CSharp.Models.Emotions;
using Basic_CSharp.Models.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;

// Assuming all needed namespaces are included
class Program
{
	static CharacterManager characterManager = new CharacterManager();
	static RelationshipManager relationshipManager = new RelationshipManager();

	static void Main(string[] args)
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8;

		while (true)
		{
			Console.Clear();
			Console.WriteLine("=== Life Simulator Game ===");
			Console.WriteLine("1. Create Character");
			Console.WriteLine("2. Delete Character");
			Console.WriteLine("3. List Characters");
			Console.WriteLine("4. Equip Item to Character");
			Console.WriteLine("5. Remove Equipment from Character");
			Console.WriteLine("6. Set Character Emotion");
			Console.WriteLine("7. Show Character Stats");
			Console.WriteLine("8. Manage Relationships");
			Console.WriteLine("0. Exit");
			Console.Write("Choose option: ");

			string input = Console.ReadLine();
			Console.WriteLine();

			switch (input)
			{
				case "1": CreateCharacter(); break;
				case "2": DeleteCharacter(); break;
				case "3": ListCharacters(); break;
				case "4": EquipItem(); break;
				case "5": RemoveItem(); break;
				case "6": SetEmotion(); break;
				case "7": ShowStats(); break;
				case "8": ManageRelationships(); break;
				case "0": return;
				default: Console.WriteLine("Invalid option."); break;
			}

			Console.WriteLine("\nPress any key to continue...");
			Console.ReadKey();
		}
	}

	static void CreateCharacter()
	{
		Console.Write("Character name: ");
		var name = Console.ReadLine();

		var stats = new Stats
		{
			HP = 100,
			Energy = 50,
			Exp = 0,
			Level = 1,
			LuckyPoint = 5,
			Charisma = 5
		};

		var character = new CharacterBuilder()
			.WithName(name)
			.WithStats(stats)
			.Build();

		characterManager.AddCharacter(character);
		Console.WriteLine($"✅ Created character: {name}");
	}

	static void DeleteCharacter()
	{
		Console.Write("Enter character name to delete: ");
		string name = Console.ReadLine();

		characterManager.RemoveCharacter(name);
		Console.WriteLine($"🗑️ Deleted character: {name}");
	}

	static void ListCharacters()
	{
		var characters = characterManager.ListCharacters();
		if (characters.Count == 0)
		{
			Console.WriteLine("⚠️ No characters.");
			return;
		}

		Console.WriteLine("🧍 Characters:");
		foreach (var name in characters)
		{
			Console.WriteLine($"- {name}");
		}
	}

	static void EquipItem()
	{
		var character = PromptCharacter();
		if (character == null) return;

		Console.WriteLine("Choose item to equip:");
		Console.WriteLine("1. Helmet");
		Console.WriteLine("2. Armor");
		Console.WriteLine("3. Shoes");
		Console.WriteLine("4. Weapon");
		string choice = Console.ReadLine();

		IEquipment item = choice switch
		{
			"1" => new Helmet(),
			"2" => new Armor(),
			"3" => new Shoes(),
			"4" => new Weapon(),
			_ => null
		};

		if (item != null)
		{
			new CharacterController(character).EquipItem(item);
			Console.WriteLine($"✅ Equipped {item.Name} to {character.Name}");
		}
	}

	static void RemoveItem()
	{
		var character = PromptCharacter();
		if (character == null) return;

		var controller = new CharacterController(character);
		controller.ListEquipment();

		Console.Write("Enter equipment name to remove: ");
		string name = Console.ReadLine();

		controller.RemoveItem(name);
		Console.WriteLine($"🗑️ Removed equipment: {name}");
	}

	static void SetEmotion()
	{
		var character = PromptCharacter();
		if (character == null) return;

		Console.WriteLine("Choose emotion:");
		Console.WriteLine("1. Happy");
		Console.WriteLine("2. Sad");
		Console.WriteLine("3. Angry");
		Console.WriteLine("4. Neutral");
		string emotionChoice = Console.ReadLine();

		IEmotionState emotion = emotionChoice switch
		{
			"1" => new HappyState(),
			"2" => new SadState(),
			"3" => new AngryState(),
			"4" => new NeutralState(),
			_ => null
		};

		if (emotion != null)
		{
			new CharacterController(character).SetEmotion(emotion);
			Console.WriteLine($"✅ {character.Name} is now {emotion.Name}");
		}
	}

	static void ShowStats()
	{
		var character = PromptCharacter();
		if (character == null) return;

		new CharacterController(character).ShowStats();
	}

	static void ManageRelationships()
	{
		Console.WriteLine("1. Add or Update Relationship");
		Console.WriteLine("2. Remove Relationship");
		Console.WriteLine("3. View All Relationships");
		Console.Write("Choose: ");
		var choice = Console.ReadLine();

		switch (choice)
		{
			case "1":
				var from = PromptCharacter("Source character name: ");
				var to = PromptCharacter("Target character name: ");
				if (from == null || to == null) return;

				Console.Write("Charisma value: ");
				if (int.TryParse(Console.ReadLine(), out int value))
				{
					relationshipManager.AddRelationship(from, to, value);
					Console.WriteLine($"✅ Relationship {from.Name} → {to.Name} set to {value}");
				}
				break;

			case "2":
				var fromR = PromptCharacter("From character: ");
				var toR = PromptCharacter("To character: ");
				if (fromR == null || toR == null) return;

				relationshipManager.RemoveRelationship(fromR.Name, toR.Name);
				Console.WriteLine("🗑️ Relationship removed.");
				break;

			case "3":
				relationshipManager.PrintAllRelationships();
				break;

			default:
				Console.WriteLine("Invalid choice.");
				break;
		}
	}

	static Character? PromptCharacter(string prompt = "Enter character name: ")
	{
		Console.Write(prompt);
		var name = Console.ReadLine();
		var character = characterManager.GetCharacter(name);

		if (character == null)
		{
			Console.WriteLine($"❌ Character '{name}' not found.");
		}

		return character;
	}
}
