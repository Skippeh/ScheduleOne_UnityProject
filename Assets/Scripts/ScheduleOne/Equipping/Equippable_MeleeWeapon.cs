namespace ScheduleOne.Equipping
{
	public class Equippable_MeleeWeapon : global::ScheduleOne.Equipping.Equippable_AvatarViewmodel
	{
		[global::UnityEngine.Header("Basic Settings")]
		public global::ScheduleOne.Combat.EImpactType ImpactType;

		public float Range;

		public float HitRadius;

		[global::UnityEngine.Header("Timing")]
		public float MaxLoadTime;

		public float MinCooldown;

		public float MaxCooldown;

		public float MinHitDelay;

		public float MaxHitDelay;

		[global::UnityEngine.Header("Damage")]
		public float MinDamage;

		public float MaxDamage;

		public float MinForce;

		public float MaxForce;

		[global::UnityEngine.Header("Stamina Settings")]
		public float MinStaminaCost;

		public float MaxStaminaCost;

		[global::UnityEngine.Header("Sound")]
		public global::ScheduleOne.Audio.AudioSourceController WhooshSound;

		public float WhooshSoundPitch;

		public global::ScheduleOne.Audio.AudioSourceController ImpactSound;

		[global::UnityEngine.Header("Animation")]
		public string SwingAnimationTrigger;

		private float load;

		private float remainingCooldown;

		private global::UnityEngine.Coroutine hitRoutine;

		private bool loadQueued;

		private bool clickReleased;

		public bool IsLoading => false;

		public bool IsAttacking { get; private set; }

		protected override void Update()
		{
		}

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
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
