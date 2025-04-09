using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	[RequireComponent(typeof(NPCHealth))]
	[DisallowMultipleComponent]
	public class NPCHealth : NetworkBehaviour
	{
		public const int REVIVE_DAYS = 3;

		[Header("Settings")]
		public bool Invincible;

		public float MaxHealth;

		private NPC npc;

		public UnityEvent onDie;

		public UnityEvent onKnockedOut;

		private bool AfflictedWithLethalEffect;

		public SyncVar<float> syncVar____003CHealth_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ENPCHealthAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ENPCHealthAssembly_002DCSharp_002Edll_Excuted;

		[field: SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
		public float Health { get; private set; }

		public bool IsDead { get; private set; }

		public bool IsKnockedOut { get; private set; }

		public int DaysPassedSinceDeath { get; private set; }

		public float SyncAccessor__003CHealth_003Ek__BackingField
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnStartServer()
		{
		}

		public void Load(NPCHealthData healthData)
		{
		}

		private void Update()
		{
		}

		public void SetAfflictedWithLethalEffect(bool value)
		{
		}

		public void SleepStart()
		{
		}

		public void TakeDamage(float damage, bool isLethal = true)
		{
		}

		public virtual void Die()
		{
		}

		public virtual void KnockOut()
		{
		}

		public virtual void Revive()
		{
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002ENPCs_002ENPCHealth(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ENPCHealth_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
