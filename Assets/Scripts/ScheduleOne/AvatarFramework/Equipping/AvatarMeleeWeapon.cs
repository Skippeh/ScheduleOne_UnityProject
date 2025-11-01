namespace ScheduleOne.AvatarFramework.Equipping
{
	public class AvatarMeleeWeapon : global::ScheduleOne.AvatarFramework.Equipping.AvatarWeapon
	{
		[global::System.Serializable]
		public class MeleeAttack
		{
			public float RangeMultiplier;

			public float DamageMultiplier;

			public string AnimationTrigger;

			public float DamageDelay;

			public float AttackSoundDelay;

			public global::UnityEngine.AudioClip[] AttackClips;

			public global::UnityEngine.AudioClip[] HitClips;
		}

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Audio.AudioSourceController AttackSound;

		public global::ScheduleOne.Audio.AudioSourceController HitSound;

		[global::UnityEngine.Header("Melee Weapon settings")]
		public global::ScheduleOne.Combat.EImpactType ImpactType;

		public float AttackRange;

		public float AttackRadius;

		public float Damage;

		public float ImpactForce;

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarMeleeWeapon.MeleeAttack[] Attacks;

		public float GruntChance;

		private global::UnityEngine.Coroutine attackRoutine;

		public override void Unequip()
		{
		}

		public override bool IsReadyToAttack()
		{
			return false;
		}

		public override void Attack()
		{
		}
	}
}
