using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Models.Equipment
{
	public class Weapon : IEquipment
	{
		public string Name => "Basic sword";

		public void Apply(Stats stats)
		{
			stats.Atk += 10;
		}
	}
}
