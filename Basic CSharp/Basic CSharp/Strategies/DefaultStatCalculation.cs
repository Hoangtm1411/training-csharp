using Basic_CSharp.Models.Emotions;
using Basic_CSharp.Models.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basic_CSharp.Models;

namespace Basic_CSharp.Strategies
{
	public class DefaultStatCalculation : IStatCalculationStrategy
	{
		public Stats Calculate(Stats baseStats, List<IEquipment> equipments, IEmotionState emotionState)
		{
			Stats finalStats = baseStats.Clone();

			// Apply emotion modifier
			emotionState.ModifyStats(finalStats);

			// Apply equipment bonuses
			foreach (var item in equipments)
			{
				item.Apply(finalStats);
			}

			return finalStats;
		}
	}

}
