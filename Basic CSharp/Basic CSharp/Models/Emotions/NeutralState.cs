using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Models.Emotions
{
	internal class NeutralState : IEmotionState
	{
		public string Name => "Neutral";

		public void ModifyStats(Stats stats)
		{
			stats.Energy = 0;
			stats.LuckyPoint += 40;
		}
	}
}
