using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Equipping
{
	public class Equippable_RangedWeapon : Equippable_AvatarViewmodel
	{
		public const float NPC_AIM_DETECTION_RANGE = 10f;

		public int MagazineSize;

		[Header("Aim Settings")]
		public float AimDuration;

		public float AimFOVReduction;

		public float FOVChangeDuration;

		[Header("Firing")]
		public AudioSourceController FireSound;

		public AudioSourceController EmptySound;

		public float FireCooldown;

		public string[] FireAnimTriggers;

		public float AccuracyChangeDuration;

		[Header("Raycasting")]
		public float Range;

		public float RayRadius;

		[Header("Spread")]
		public float MinSpread;

		public float MaxSpread;

		[Header("Damage")]
		public float Damage;

		public float ImpactForce;

		[Header("Reloading")]
		public bool CanReload;

		public bool IncrementalReload;

		public StorableItemDefinition Magazine;

		public float ReloadStartTime;

		public float ReloadIndividalTime;

		public float ReloadEndTime;

		public string ReloadStartAnimTrigger;

		public string ReloadIndividualAnimTrigger;

		public string ReloadEndAnimTrigger;

		public TrashItem ReloadTrash;

		[Header("Cocking")]
		public bool MustBeCocked;

		public float CockTime;

		public string CockAnimTrigger;

		[Header("Effects")]
		public float TracerSpeed;

		public UnityEvent onFire;

		public UnityEvent onReloadStart;

		public UnityEvent onReloadIndividual;

		public UnityEvent onReloadEnd;

		public UnityEvent onCockStart;

		protected IntegerItemInstance weaponItem;

		private bool fovOverridden;

		private float aimVelocity;

		private Coroutine reloadRoutine;

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

		public override void Equip(ItemInstance item)
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

		protected virtual bool GetMagazine(out StorableItemInstance mag)
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

		private float GetSpread()
		{
			return 0f;
		}

		private void CheckAimingAtNPC()
		{
		}
	}
}
