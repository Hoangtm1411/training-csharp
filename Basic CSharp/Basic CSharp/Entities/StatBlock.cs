using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Entities
{
	class StatBlock
	{
		public float Hp { get; set; }
		public float Energy { get; set; }
		public float Exp { get; set; }
		public int Level { get; set; }
		public float LuckyPoint { get; set; }

		public void GainExp(float amount) {}
		public void TakeDamage(float dmg) {}
	}

}
