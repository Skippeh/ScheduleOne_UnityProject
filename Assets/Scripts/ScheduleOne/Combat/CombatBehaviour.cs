namespace ScheduleOne.Combat
{
	public class CombatBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass78_0
		{
			public global::ScheduleOne.Combat.CombatBehaviour _003C_003E4__this;

			public global::ScheduleOne.AvatarFramework.Equipping.AvatarRangedWeapon rangedWeapon;

			public global::System.Func<bool> _003C_003E9__1;

			internal bool _003CRangedWeaponRoutine_003Eb__1()
			{
				return false;
			}
		}

		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Auto)]
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private struct _003C_003Ec__DisplayClass78_1
		{
			public global::ScheduleOne.Combat.ERangedWeaponAction action;

			public int shots;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CRangedWeaponRoutine_003Ed__78 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Combat.CombatBehaviour _003C_003E4__this;

			private global::ScheduleOne.Combat.CombatBehaviour._003C_003Ec__DisplayClass78_0 _003C_003E8__1;

			private global::ScheduleOne.Combat.CombatBehaviour._003C_003Ec__DisplayClass78_1 _003C_003E8__2;

			private bool _003CforceReposition_003E5__2;

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
			public _003CRangedWeaponRoutine_003Ed__78(int _003C_003E1__state)
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

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CRepositionToRangedWeaponRange_003Ed__79 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Combat.CombatBehaviour _003C_003E4__this;

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
			public _003CRepositionToRangedWeaponRange_003Ed__79(int _003C_003E1__state)
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

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CSearchRoutine_003Ed__92 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Combat.CombatBehaviour _003C_003E4__this;

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
			public _003CSearchRoutine_003Ed__92(int _003C_003E1__state)
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

		public const float RECENT_VISIBILITY_THRESHOLD = 3.5f;

		public const float REPOSITION_TIME = 4f;

		public const float SEARCH_RADIUS_MIN = 25f;

		public const float SEARCH_RADIUS_MAX = 60f;

		public const float SEARCH_SPEED = 0.4f;

		public const float CONSECUTIVE_MISS_ACCURACY_BOOST = 0.1f;

		public const float REACHED_DESTINATION_DISTANCE = 2f;

		public bool DEBUG;

		[global::UnityEngine.Header("General Setttings")]
		public float GiveUpRange;

		public int GiveUpAfterSuccessfulHits;

		public bool PlayAngryVO;

		[global::UnityEngine.Header("Movement settings")]
		[global::UnityEngine.Range(0f, 1f)]
		public float DefaultMovementSpeed;

		[global::UnityEngine.Header("Weapon settings")]
		public global::ScheduleOne.AvatarFramework.Equipping.AvatarWeapon DefaultWeapon;

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarMeleeWeapon VirtualPunchWeapon;

		[global::UnityEngine.Header("Search settings")]
		public float DefaultSearchTime;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Tools.SmoothedVelocityCalculator TargetVelocityTracker;

		[global::UnityEngine.Header("Debug settings")]
		public bool CombatOnStart;

		public global::FishNet.Object.NetworkObject DebugTarget;

		protected float timeSinceLastSighting;

		protected global::UnityEngine.Vector3 lastKnownTargetPosition;

		private float timeSinceLastReposition;

		private float timeWithinAttackRange;

		private bool visionEventReceived;

		protected global::ScheduleOne.AvatarFramework.Equipping.AvatarWeapon currentWeapon;

		protected int successfulHits;

		protected int consecutiveMissedShots;

		protected global::UnityEngine.Coroutine rangedWeaponRoutine;

		protected global::UnityEngine.Coroutine searchRoutine;

		protected global::UnityEngine.Vector3 currentSearchDestination;

		protected bool hasSearchDestination;

		private float nextAngryVO;

		public global::System.Action onSuccessfulHit;

		private bool NetworkInitialize___EarlyScheduleOne_002ECombat_002ECombatBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECombat_002ECombatBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Combat.ICombatTargetable Target { get; protected set; }

		public bool IsSearching { get; protected set; }

		public float TimeSinceTargetReacquired { get; protected set; }

		public bool IsTargetRecentlyVisible { get; private set; }

		public bool IsTargetImmediatelyVisible { get; private set; }

		public override void Awake()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTargetAndEnable_Server(global::FishNet.Object.NetworkObject target)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		protected void SetTarget_Client(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject target)
		{
		}

		protected virtual void SetTarget(global::FishNet.Object.NetworkObject target)
		{
		}

		public override void Begin()
		{
		}

		public override void Resume()
		{
		}

		public override void Pause()
		{
		}

		public override void End()
		{
		}

		public override void Disable()
		{
		}

		protected virtual void StartCombat()
		{
		}

		protected virtual void EndCombat()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		protected void UpdateTimeout()
		{
		}

		protected virtual void UpdateLookAt()
		{
		}

		protected void SetMovementSpeed(float speed, string label = "combat", int priority = 5)
		{
		}

		private void EnsureRangedWeaponRoutineIsRunning()
		{
		}

		protected global::UnityEngine.Vector3 GetPredictedFutureTargetPosition(float lead_Min = 0f, float lead_Max = 2f)
		{
			return default(global::UnityEngine.Vector3);
		}

		protected override void SetDestination(global::UnityEngine.Vector3 position, bool teleportIfFail = true, float successThreshold = 1f)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		protected virtual void SetWeapon(string weaponPath)
		{
		}

		protected virtual void OnCurrentWeaponChanged(global::ScheduleOne.AvatarFramework.Equipping.AvatarWeapon weapon)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		protected void ClearWeapon()
		{
		}

		protected virtual bool ReadyToAttack(bool checkTarget = true)
		{
			return false;
		}

		private bool IsCurrentWeaponMelee()
		{
			return false;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		protected virtual void Attack()
		{
		}

		protected void SucessfulHit()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Combat.CombatBehaviour._003CRangedWeaponRoutine_003Ed__78))]
		private global::System.Collections.IEnumerator RangedWeaponRoutine()
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Combat.CombatBehaviour._003CRepositionToRangedWeaponRange_003Ed__79))]
		private global::System.Collections.IEnumerator RepositionToRangedWeaponRange()
		{
			return null;
		}

		protected virtual float GetIdealRangedWeaponDistance()
		{
			return 0f;
		}

		private bool Shoot()
		{
			return false;
		}

		private void SetWeaponRaised(bool raised)
		{
		}

		protected void CheckTargetVisibility()
		{
		}

		public void MarkPlayerVisible()
		{
		}

		protected bool IsTargetVisibleThisFrame()
		{
			return false;
		}

		protected void ProcessVisionEvent(global::ScheduleOne.Vision.VisionEventReceipt visionEventReceipt)
		{
		}

		protected virtual void TargetSpotted()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void NotifyServerTargetSeen()
		{
		}

		protected virtual float GetSearchTime()
		{
			return 0f;
		}

		private void StartSearching()
		{
		}

		private void StopSearching()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Combat.CombatBehaviour._003CSearchRoutine_003Ed__92))]
		private global::System.Collections.IEnumerator SearchRoutine()
		{
			return null;
		}

		private global::UnityEngine.Vector3 GetNextSearchLocation()
		{
			return default(global::UnityEngine.Vector3);
		}

		protected virtual bool IsTargetValid()
		{
			return false;
		}

		private void RepositionToTargetMeleeRange(global::UnityEngine.Vector3 origin)
		{
		}

		private bool GetRandomReachablePointNear(global::UnityEngine.Vector3 originPoint, float randomRadius, out global::UnityEngine.Vector3 randomPoint, float minDistance = 0f)
		{
			randomPoint = default(global::UnityEngine.Vector3);
			return false;
		}

		protected float GetMinTargetDistance()
		{
			return 0f;
		}

		protected float GetMaxTargetDistance()
		{
			return 0f;
		}

		protected bool IsTargetInRange(global::UnityEngine.Vector3 origin = default(global::UnityEngine.Vector3))
		{
			return false;
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_SetTargetAndEnable_Server_3323014238(global::FishNet.Object.NetworkObject target)
		{
		}

		public void RpcLogic___SetTargetAndEnable_Server_3323014238(global::FishNet.Object.NetworkObject target)
		{
		}

		private void RpcReader___Server_SetTargetAndEnable_Server_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetTarget_Client_1824087381(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject target)
		{
		}

		protected void RpcLogic___SetTarget_Client_1824087381(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject target)
		{
		}

		private void RpcReader___Observers_SetTarget_Client_1824087381(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetTarget_Client_1824087381(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject target)
		{
		}

		private void RpcReader___Target_SetTarget_Client_1824087381(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetWeapon_3615296227(string weaponPath)
		{
		}

		protected virtual void RpcLogic___SetWeapon_3615296227(string weaponPath)
		{
		}

		private void RpcReader___Observers_SetWeapon_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ClearWeapon_2166136261()
		{
		}

		protected void RpcLogic___ClearWeapon_2166136261()
		{
		}

		private void RpcReader___Observers_ClearWeapon_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_Attack_2166136261()
		{
		}

		protected virtual void RpcLogic___Attack_2166136261()
		{
		}

		private void RpcReader___Observers_Attack_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_NotifyServerTargetSeen_2166136261()
		{
		}

		public void RpcLogic___NotifyServerTargetSeen_2166136261()
		{
		}

		private void RpcReader___Server_NotifyServerTargetSeen_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ECombat_002ECombatBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
