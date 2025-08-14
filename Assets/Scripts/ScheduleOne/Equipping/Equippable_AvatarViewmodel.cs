namespace ScheduleOne.Equipping
{
	public class Equippable_AvatarViewmodel : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		public global::UnityEngine.RuntimeAnimatorController AnimatorController;

		public global::UnityEngine.Vector3 ViewmodelAvatarOffset;

		public global::UnityEngine.Vector3 ViewmodelAvatarRotationOffset;

		[global::UnityEngine.Header("Equipping")]
		public float EquipTime;

		public string EquipTrigger;

		protected float timeEquipped;

		protected bool equipAnimDone => false;

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
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
