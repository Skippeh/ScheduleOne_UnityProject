using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	public class Equippable_MeleeWeapon : Equippable_AvatarViewmodel
	{
		[Header("Basic Settings")]
		public EImpactType ImpactType;

		public float Range;

		public float HitRadius;

		[Header("Timing")]
		public float MaxLoadTime;

		public float MinCooldown;

		public float MaxCooldown;

		public float MinHitDelay;

		public float MaxHitDelay;

		[Header("Damage")]
		public float MinDamage;

		public float MaxDamage;

		public float MinForce;

		public float MaxForce;

		[Header("Stamina Settings")]
		public float MinStaminaCost;

		public float MaxStaminaCost;

		[Header("Sound")]
		public AudioSourceController WhooshSound;

		public float WhooshSoundPitch;

		public AudioSourceController ImpactSound;

		[Header("Animation")]
		public string SwingAnimationTrigger;

		private float load;

		private float remainingCooldown;

		private Coroutine hitRoutine;

		private bool loadQueued;

		private bool clickReleased;

		public bool IsLoading => false;

		public bool IsAttacking { get; private set; }

		protected override void Update()
		{
		}

		public override void Equip(ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		private void UpdateCooldown()
		{
		}

		private void UpdateInput()
		{
		}

		private bool CanStartLoading()
		{
			return false;
		}

		private void StartLoad()
		{
		}

		private void Release()
		{
		}

		private void Hit(float power)
		{
		}

		private void ExecuteHit(float power)
		{
		}
	}
}
