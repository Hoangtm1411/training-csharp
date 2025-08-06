using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Models
{
	public class Stats
	{
		public int HP { get; set; }
		public int Energy { get; set; }
		public int Exp { get; set; }
		public int Level { get; set; }
		public int LuckyPoint { get; set; }
		public int Charisma { get; set; }

		public Stats Clone() => (Stats)this.MemberwiseClone();
	}
}
