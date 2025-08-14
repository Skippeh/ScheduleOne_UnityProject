namespace ScheduleOne.Equipping
{
	public class Equippable_RangedWeapon : global::ScheduleOne.Equipping.Equippable_AvatarViewmodel
	{
		public enum EReloadType
		{
			Magazine = 0,
			Incremental = 1
		}

		public const float NPC_AIM_DETECTION_RANGE = 10f;

		public int MagazineSize;

		[global::UnityEngine.Header("Aim Settings")]
		public float AimDuration;

		public float AimFOVReduction;

		[global::UnityEngine.Header("Firing")]
		public global::ScheduleOne.Audio.AudioSourceController FireSound;

		public global::ScheduleOne.Audio.AudioSourceController EmptySound;

		public float FireCooldown;

		public string[] FireAnimTriggers;

		public float AccuracyChangeDuration;

		[global::UnityEngine.Header("Raycasting")]
		public float Range;

		public float RayRadius;

		[global::UnityEngine.Header("Spread")]
		public float MinSpread;

		public float MaxSpread;

		[global::UnityEngine.Header("Damage")]
		public float Damage;

		public float ImpactForce;

		[global::UnityEngine.Header("Reloading")]
		public bool CanReload;

		public global::ScheduleOne.Equipping.Equippable_RangedWeapon.EReloadType ReloadType;

		public global::ScheduleOne.ItemFramework.StorableItemDefinition Magazine;

		public float ReloadStartTime;

		public float ReloadIndividalTime;

		public float ReloadEndTime;

		public string ReloadStartAnimTrigger;

		public string ReloadIndividualAnimTrigger;

		public string ReloadEndAnimTrigger;

		public global::ScheduleOne.Trash.TrashItem ReloadTrash;

		[global::UnityEngine.Header("Cocking")]
		public bool MustBeCocked;

		public bool CockedByDefault;

		public bool AutoCockAfterReload;

		public float CockTime;

		public string CockAnimTrigger;

		[global::UnityEngine.Header("Effects")]
		public float TracerSpeed;

		public global::UnityEngine.Events.UnityEvent onFire;

		public global::UnityEngine.Events.UnityEvent onReloadStart;

		public global::UnityEngine.Events.UnityEvent onReloadIndividual;

		public global::UnityEngine.Events.UnityEvent onReloadEnd;

		public global::UnityEngine.Events.UnityEvent onCockStart;

		protected global::ScheduleOne.ItemFramework.IntegerItemInstance weaponItem;

		private bool fovOverridden;

		private float aimVelocity;

		private global::UnityEngine.Coroutine reloadRoutine;

		private bool shotQueued;

		private bool reloadQueued;

		private float timeSincePrimaryClick;

		public float Aim { get; private set; }

		public float Accuracy { get; private set; }

		public float TimeSinceFire { get; set; }

		public bool IsReloading { get; private set; }

		public bool IsCocked { get; private set; }

		public bool IsCocking { get; private set; }

		public int Ammo => 0;

		private float aimFov => 0f;

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		protected override void Update()
		{
		}

		private void UpdateInput()
		{
		}

		private void UpdateAnim()
		{
		}

		private bool CanAim()
		{
			return false;
		}

		public virtual void Fire()
		{
		}

		protected virtual global::UnityEngine.Vector3[] GetBulletDirections()
		{
			return null;
		}

		protected static global::UnityEngine.Vector3 SpreadDirection(global::UnityEngine.Vector3 direction, float maxAngle)
		{
			return default(global::UnityEngine.Vector3);
		}

		public virtual void Reload()
		{
		}

		protected virtual void NotifyIncrementalReload()
		{
		}

		private bool IsReloadReady(bool ignoreTiming)
		{
			return false;
		}

		protected virtual bool GetMagazine(out global::ScheduleOne.Storage.StorableItemInstance mag)
		{
			mag = null;
			return false;
		}

		private bool CanFire(bool checkAmmo = true)
		{
			return false;
		}

		private bool CanCock()
		{
			return false;
		}

		private void Cock()
		{
		}

		protected float GetSpreadAngle()
		{
			return 0f;
		}

		private void CheckAimingAtNPC()
		{
		}
	}
}
