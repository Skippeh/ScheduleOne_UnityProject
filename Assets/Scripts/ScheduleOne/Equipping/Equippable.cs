using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	public class Equippable : MonoBehaviour
	{
		protected ItemInstance itemInstance;

		public bool CanInteractWhenEquipped;

		public bool CanPickUpWhenEquipped;

		public virtual void Equip(ItemInstance item)
		{
		}

		public virtual void Unequip()
		{
		}
	}
}
