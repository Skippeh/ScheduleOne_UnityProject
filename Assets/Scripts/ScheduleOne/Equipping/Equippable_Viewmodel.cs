using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	public class Equippable_Viewmodel : Equippable_StorableItem
	{
		[Header("Viewmodel settings")]
		public Vector3 localPosition;

		public Vector3 localEulerAngles;

		public Vector3 localScale;

		[Header("Third person animation settings")]
		public AvatarEquippable AvatarEquippable;

		public override void Equip(ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		protected virtual void PlayEquipAnimation()
		{
		}

		protected virtual void PlayUnequipAnimation()
		{
		}
	}
}
