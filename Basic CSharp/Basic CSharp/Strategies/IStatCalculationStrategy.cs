using Basic_CSharp.Models.Emotions;
using Basic_CSharp.Models.Equipment;
using Basic_CSharp.Models;

namespace Basic_CSharp.Strategies
{
	public interface IStatCalculationStrategy
	{
		Stats Calculate(Stats baseStats, List<IEquipment> equipments, IEmotionState emotionState);
	}
}
