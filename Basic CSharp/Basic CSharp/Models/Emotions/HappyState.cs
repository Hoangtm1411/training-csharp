using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Models.Emotions
{
	public class HappyState : IEmotionState
	{
		public string Name => "Happy";

		public void ModifyStats(Stats stats)
		{
			stats.Energy += 10;
			stats.LuckyPoint += 5;
		}
	}
}
