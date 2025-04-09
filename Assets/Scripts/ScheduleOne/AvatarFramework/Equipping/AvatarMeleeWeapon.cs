using System;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	public class AvatarMeleeWeapon : AvatarWeapon
	{
		[Serializable]
		public class MeleeAttack
		{
			public float RangeMultiplier;

			public float DamageMultiplier;

			public string AnimationTrigger;

			public float DamageDelay;

			public float AttackSoundDelay;

			public AudioClip[] AttackClips;

			public AudioClip[] HitClips;
		}

		public const float GruntChance = 0.4f;

		[Header("References")]
		public AudioSourceController AttackSound;

		public AudioSourceController HitSound;

		[Header("Melee Weapon settings")]
		public float AttackRange;

		public float AttackRadius;

		public float Damage;

		public MeleeAttack[] Attacks;

		private Coroutine attackRoutine;

		public override void Unequip()
		{
		}

		public override void Attack()
		{
		}
	}
}
