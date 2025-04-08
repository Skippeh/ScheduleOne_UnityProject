namespace ScheduleOne.NPCs.Behaviour
{
	public class PursuitBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		private enum EPursuitAction
		{
			None = 0,
			Move = 1,
			Shoot = 2,
			MoveAndShoot = 3
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CRangedWeaponRoutine_003Ed__59 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.NPCs.Behaviour.PursuitBehaviour _003C_003E4__this;

			private global::ScheduleOne.NPCs.Behaviour.PursuitBehaviour.EPursuitAction _003CcurrentAction_003E5__2;

			private float _003CcurrentActionDuration_003E5__3;

			private float _003CcurrentActionTime_003E5__4;

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
			public _003CRangedWeaponRoutine_003Ed__59(int _003C_003E1__state)
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
		private sealed class _003CSearchRoutine_003Ed__82 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.NPCs.Behaviour.PursuitBehaviour _003C_003E4__this;

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
			public _003CSearchRoutine_003Ed__82(int _003C_003E1__state)
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

		public const float ARREST_RANGE = 2.5f;

		public const float ARREST_TIME = 1.75f;

		public const float EXTRA_VISIBILITY_TIME = 2f;

		public const float MOVE_SPEED_INVESTIGATING = 0.35f;

		public const float MOVE_SPEED_ARRESTING = 0.6f;

		public const float MOVE_SPEED_CHASE = 0.8f;

		public const float MOVE_SPEED_SHOOTING = 0.15f;

		public const float SEARCH_RADIUS_MIN = 25f;

		public const float SEARCH_RADIUS_MAX = 80f;

		public const float ARREST_MAX_DISTANCE = 15f;

		public const int LEAVE_ARREST_CIRCLE_LIMIT = 3;

		public const float CONSECUTIVE_MISS_ACCURACY_BOOST = 0.1f;

		[global::UnityEngine.Header("Settings")]
		public float ArrestCircle_MaxVisibleDistance;

		public float ArrestCircle_MaxOpacity;

		[global::FishNet.Object.Synchronizing.SyncVar(SendRate = 0.25f, WritePermissions = global::FishNet.Object.Synchronizing.WritePermission.ClientUnsynchronized)]
		public bool isTargetVisible;

		protected bool isTargetStrictlyVisible;

		protected bool arrestingEnabled;

		protected float timeSinceLastSighting;

		protected float currentPursuitLevelDuration;

		protected float timeWithinArrestRange;

		protected float playerSightedDuration;

		protected float distanceOnPursuitStart;

		private global::UnityEngine.Coroutine searchRoutine;

		private global::UnityEngine.Coroutine rangedWeaponRoutine;

		private global::UnityEngine.Vector3 currentSearchDestination;

		private bool hasSearchDestination;

		private global::ScheduleOne.Police.PoliceOfficer officer;

		private bool targetWasDrivingOnPursuitStart;

		private bool wasInArrestCircleLastFrame;

		private int leaveArrestCircleCount;

		private global::ScheduleOne.AvatarFramework.Equipping.AvatarRangedWeapon rangedWeapon;

		private int consecutiveMissedShots;

		private float nextAngryVO;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar___isTargetVisible;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EPursuitBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EPursuitBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.PlayerScripts.Player TargetPlayer { get; protected set; }

		public bool IsSearching { get; protected set; }

		public bool SyncAccessor_isTargetVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public virtual void AssignTarget(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject target)
		{
		}

		protected override void Begin()
		{
		}

		protected override void Resume()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		public override void ActiveMinPass()
		{
		}

		private bool IsTargetValid()
		{
			return false;
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void UpdateInvestigatingBehaviour()
		{
		}

		protected virtual void UpdateArrestBehaviour()
		{
		}

		private void UpdateArrest(float tick)
		{
		}

		private global::UnityEngine.Vector3 GetNewArrestDestination()
		{
			return default(global::UnityEngine.Vector3);
		}

		private void ClearSpeedControls()
		{
		}

		protected virtual void UpdateNonLethalBehaviour()
		{
		}

		protected virtual void UpdateLethalBehaviour()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.NPCs.Behaviour.PursuitBehaviour._003CRangedWeaponRoutine_003Ed__59))]
		private global::System.Collections.IEnumerator RangedWeaponRoutine()
		{
			return null;
		}

		private bool CanShoot()
		{
			return false;
		}

		private bool Shoot()
		{
			return false;
		}

		private void SetWeaponRaised(bool raised)
		{
		}

		private void StopRangedWeaponRoutine()
		{
		}

		protected virtual void UpdateLookAt()
		{
		}

		protected virtual void UpdateEquippable()
		{
		}

		public override void Disable()
		{
		}

		protected override void Pause()
		{
		}

		protected override void End()
		{
		}

		private void Stop()
		{
		}

		private void ClearEquippables()
		{
		}

		protected void CheckPlayerVisibility()
		{
		}

		public void MarkPlayerVisible()
		{
		}

		protected bool IsPlayerVisible()
		{
			return false;
		}

		private void ProcessVisionEvent(global::ScheduleOne.Vision.VisionEventReceipt visionEventReceipt)
		{
		}

		private void ProcessThirdPartyVisionEvent(global::ScheduleOne.Vision.VisionEventReceipt visionEventReceipt)
		{
		}

		protected virtual void UpdateArrestCircle()
		{
		}

		public void ResetArrestProgress()
		{
		}

		private void SetArrestCircleAlpha(float alpha)
		{
		}

		private void SetArrestCircleColor(global::UnityEngine.Color col)
		{
		}

		private void StartSearching()
		{
		}

		private void StopSearching()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.NPCs.Behaviour.PursuitBehaviour._003CSearchRoutine_003Ed__82))]
		private global::System.Collections.IEnumerator SearchRoutine()
		{
			return null;
		}

		private global::UnityEngine.Vector3 GetNextSearchLocation()
		{
			return default(global::UnityEngine.Vector3);
		}

		private global::UnityEngine.Vector3 GetRandomReachablePointNear(global::UnityEngine.Vector3 point, float randomRadius, float minDistance = 0f)
		{
			return default(global::UnityEngine.Vector3);
		}

		private void SetWorldspaceIconsActive(bool active)
		{
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

		private void RpcWriter___Observers_AssignTarget_1824087381(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject target)
		{
		}

		public virtual void RpcLogic___AssignTarget_1824087381(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject target)
		{
		}

		private void RpcReader___Observers_AssignTarget_1824087381(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002ENPCs_002EBehaviour_002EPursuitBehaviour(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EPursuitBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
