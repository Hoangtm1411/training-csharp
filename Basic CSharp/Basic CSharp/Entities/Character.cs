using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Entities
{
	abstract class Character
	{
		public string Name { get; set; }
		public StatBlock Stats { get; set; }
		// public Inventory Inventory { get; set; }
		public RelationshipSystem Relationships { get; set; }
		public float Charisma { get; set; }

		public virtual void Interact(Character other) {}
		class Inventory
		{
			private Dictionary<EquipmentSlot, Equipment> equippedItems;
			public void Equip(Equipment item) {}
			public void Unequip(EquipmentSlot slot) {}
		}

	}

}
