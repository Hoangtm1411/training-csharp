using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Models.Equipment
{
	public interface IEquipment
	{
		string Name { get; }
		void Apply(Stats stats);
	}
}
