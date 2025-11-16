namespace ScheduleOne.Equipping
{
	public class Equippable_Viewmodel : global::ScheduleOne.Equipping.Equippable
	{
		[global::UnityEngine.Header("Viewmodel settings")]
		public global::UnityEngine.Vector3 localPosition;

		public global::UnityEngine.Vector3 localEulerAngles;

		public global::UnityEngine.Vector3 localScale;

		[global::UnityEngine.Header("Third person animation settings")]
		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable AvatarEquippable;

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
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
