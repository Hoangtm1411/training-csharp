using Basic_CSharp.Models.Emotions;
using Basic_CSharp.Models.Equipment;
using Basic_CSharp.Observers;
using Basic_CSharp.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Models
{
	public class Character
	{
		public string Name { get; private set; }
		public Stats BaseStats { get; private set; }
		public IEmotionState EmotionState { get; private set; }
		public List<IEquipment> Equipments { get; private set; } = new();
		public List<ICharacterObserver> Observers { get; private set; } = new();
		private IStatCalculationStrategy _strategy;

		public Character(string name, Stats stats, IStatCalculationStrategy strategy)
		{
			Name = name;
			BaseStats = stats;
			_strategy = strategy;
			EmotionState = new NeutralState();
		}

		public Stats GetCurrentStats() => _strategy.Calculate(BaseStats, Equipments, EmotionState);

		public void Equip(IEquipment equipment)
		{
			Equipments.Add(equipment);
			NotifyObservers();
		}

		public void ChangeEmotion(IEmotionState newState)
		{
			EmotionState = newState;
			NotifyObservers();
		}

		public void AttachObserver(ICharacterObserver observer) => Observers.Add(observer);
		private void NotifyObservers()
		{
			foreach (var observer in Observers)
				observer.OnCharacterChanged(this);
		}
	}

}
