namespace ScheduleOne.AvatarFramework.Equipping
{
	public class AvatarWeapon : global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable
	{
		[global::UnityEngine.Header("Range settings")]
		public float MinUseRange;

		public float MaxUseRange;

		[global::UnityEngine.Header("Cooldown settings")]
		public float CooldownDuration;

		[global::UnityEngine.Header("Equipping")]
		public global::UnityEngine.AudioClip[] EquipClips;

		public global::ScheduleOne.Audio.AudioSourceController EquipSound;

		public global::UnityEngine.Events.UnityEvent onSuccessfulHit;

		public float LastUseTime { get; private set; }

		public override void Equip(global::ScheduleOne.AvatarFramework.Avatar _avatar)
		{
		}

		public virtual void Attack()
		{
		}

		public virtual bool IsReadyToAttack()
		{
			return false;
		}
	}
}
