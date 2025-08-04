using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Entities
{
	enum EquipmentSlot
	{
		Helmet,
		Armor,
		Boots,
		Weapon
	}

	class Equipment
	{
		public string Name { get; set; }
		public EquipmentSlot Slot { get; set; }
		public Dictionary<string, float> StatModifiers { get; set; }
	}

}
