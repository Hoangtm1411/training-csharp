using Basic_CSharp.Models;
using Basic_CSharp.Strategies;

namespace Basic_CSharp.Builders
{
	public class CharacterBuilder
	{
		private string _name;
		private Stats _stats = new();
		private IStatCalculationStrategy _strategy = new DefaultStatCalculation();

		public CharacterBuilder WithName(string name)
		{
			_name = name;
			return this;
		}

		public CharacterBuilder WithStats(Stats stats)
		{
			_stats = stats;
			return this;
		}

		public CharacterBuilder WithStrategy(IStatCalculationStrategy strategy)
		{
			_strategy = strategy;
			return this;
		}

		public Character Build()
		{
			return new Character(_name, _stats, _strategy);
		}
	}

}
