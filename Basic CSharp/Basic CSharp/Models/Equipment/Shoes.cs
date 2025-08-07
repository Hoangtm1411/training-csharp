using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Models.Equipment
{
	public class Shoes : IEquipment
	{
		public string Name => "Basic Shoes";

		public void Apply(Stats stats)
		{
			stats.HP += 4;
		}
	}
}
