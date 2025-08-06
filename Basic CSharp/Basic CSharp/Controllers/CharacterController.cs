using Basic_CSharp.Models;
using Basic_CSharp.Models.Emotions;
using Basic_CSharp.Models.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp.Controllers
{
	public class CharacterController
	{
		private Character _character;

		public CharacterController(Character character)
		{
			_character = character;
		}

		public void SetEmotion(IEmotionState emotion)
		{
			_character.ChangeEmotion(emotion);
		}

		public void EquipItem(IEquipment item)
		{
			_character.Equip(item);
		}

		public Stats ShowStats()
		{
			return _character.GetCurrentStats();
		}
	}

}
