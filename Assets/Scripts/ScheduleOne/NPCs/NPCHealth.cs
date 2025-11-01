namespace ScheduleOne.NPCs
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.NPCs.NPCHealth))]
	[global::UnityEngine.DisallowMultipleComponent]
	public class NPCHealth : global::FishNet.Object.NetworkBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CAfflictWithLethalEffect_003Ed__38 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.NPCs.NPCHealth _003C_003E4__this;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CAfflictWithLethalEffect_003Ed__38(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		public const int REVIVE_DAYS = 3;

		[global::UnityEngine.Header("Settings")]
		public bool Invincible;

		public float MaxHealth;

		public bool CanRevive;

		private global::ScheduleOne.NPCs.NPC npc;

		public global::UnityEngine.Events.UnityEvent onDie;

		public global::UnityEngine.Events.UnityEvent onKnockedOut;

		public global::UnityEngine.Events.UnityEvent onDieOrKnockedOut;

		public global::UnityEngine.Events.UnityEvent onRevive;

		public global::System.Action<float> onTakeDamage;

		private bool AfflictedWithLethalEffect;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar____003CHealth_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ENPCHealthAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ENPCHealthAssembly_002DCSharp_002Edll_Excuted;

		public float Health
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return 0f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
			}
		}

		public float NormalizedHealth => 0f;

		public bool IsDead { get; private set; }

		public bool IsKnockedOut { get; private set; }

		public int DaysPassedSinceDeath { get; private set; }

		public int HoursSinceAttackedByPlayer { get; private set; }

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

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnStartServer()
		{
		}

		public void Load(global::ScheduleOne.Persistence.Datas.NPCHealthData healthData)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.NPCs.NPCHealth._003CAfflictWithLethalEffect_003Ed__38))]
		private global::System.Collections.IEnumerator AfflictWithLethalEffect()
		{
			return null;
		}

		protected virtual void OnHourPass()
		{
		}

		public void SetAfflictedWithLethalEffect(bool value)
		{
		}

		public void SleepStart()
		{
		}

		public virtual void NotifyAttackedByPlayer(global::ScheduleOne.PlayerScripts.Player player)
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

		public void RestoreHealth()
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

		public virtual bool ReadSyncVar___ScheduleOne_002ENPCs_002ENPCHealth(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ENPCHealth_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
