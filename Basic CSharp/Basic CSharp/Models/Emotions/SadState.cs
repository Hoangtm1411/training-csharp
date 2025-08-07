using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Models.Emotions
{
	internal class SadState : IEmotionState
	{
		public string Name => "Sad";
		public void ModifyStats(Stats stats)
		{
			stats.Energy = -20;
			stats.LuckyPoint -= 20;
		}
	}
}
