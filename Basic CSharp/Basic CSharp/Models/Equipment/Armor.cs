using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Models.Equipment
{
	public class Armor : IEquipment
	{
		public string Name => "Steel Armor";

		public void Apply(Stats stats)
		{
			stats.HP += 15;
		}
	}

}
