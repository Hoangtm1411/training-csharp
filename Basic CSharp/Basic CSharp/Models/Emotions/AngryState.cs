using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Models.Emotions
{
	public class AngryState : IEmotionState
	{
		public string Name => "Angry";

		public void ModifyStats(Stats stats)
		{
			stats.Energy += 5;
			stats.Charisma -= 5;
		}
	}

}
