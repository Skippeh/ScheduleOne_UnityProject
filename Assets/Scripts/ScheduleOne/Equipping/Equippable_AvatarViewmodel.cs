using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	public class Equippable_AvatarViewmodel : Equippable_Viewmodel
	{
		public RuntimeAnimatorController AnimatorController;

		public Vector3 ViewmodelAvatarOffset;

		[Header("Equipping")]
		public float EquipTime;

		public string EquipTrigger;

		protected float timeEquipped;

		protected bool equipAnimDone => false;

		public override void Equip(ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		protected override void PlayEquipAnimation()
		{
		}

		protected override void Update()
		{
		}
	}
}
