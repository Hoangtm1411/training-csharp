using Basic_CSharp.Models.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Models
{
	public class Helmet : IEquipment
	{
		public string Name => "Steel Helmet";

		public void Apply(Stats stats)
		{
			stats.HP += 10;
		}
	}

}
