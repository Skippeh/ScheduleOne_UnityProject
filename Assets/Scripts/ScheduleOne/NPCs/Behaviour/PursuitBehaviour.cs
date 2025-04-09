using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class PursuitBehaviour : Behaviour
	{
		private enum EPursuitAction
		{
			None = 0,
			Move = 1,
			Shoot = 2,
			MoveAndShoot = 3
		}

		[CompilerGenerated]
		private sealed class _003CRangedWeaponRoutine_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PursuitBehaviour _003C_003E4__this;

			private EPursuitAction _003CcurrentAction_003E5__2;

			private float _003CcurrentActionDuration_003E5__3;

			private float _003CcurrentActionTime_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CRangedWeaponRoutine_003Ed__59(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSearchRoutine_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PursuitBehaviour _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSearchRoutine_003Ed__82(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
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

		[Header("Settings")]
		public float ArrestCircle_MaxVisibleDistance;

		public float ArrestCircle_MaxOpacity;

		[SyncVar(SendRate = 0.25f, WritePermissions = WritePermission.ClientUnsynchronized)]
		public bool isTargetVisible;

		protected bool isTargetStrictlyVisible;

		protected bool arrestingEnabled;

		protected float timeSinceLastSighting;

		protected float currentPursuitLevelDuration;

		protected float timeWithinArrestRange;

		protected float playerSightedDuration;

		protected float distanceOnPursuitStart;

		private Coroutine searchRoutine;

		private Coroutine rangedWeaponRoutine;

		private Vector3 currentSearchDestination;

		private bool hasSearchDestination;

		private PoliceOfficer officer;

		private bool targetWasDrivingOnPursuitStart;

		private bool wasInArrestCircleLastFrame;

		private int leaveArrestCircleCount;

		private AvatarRangedWeapon rangedWeapon;

		private int consecutiveMissedShots;

		private float nextAngryVO;

		public SyncVar<bool> syncVar___isTargetVisible;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EPursuitBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EPursuitBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public Player TargetPlayer { get; protected set; }

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

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public virtual void AssignTarget(NetworkConnection conn, NetworkObject target)
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

		private Vector3 GetNewArrestDestination()
		{
			return default(Vector3);
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

		[IteratorStateMachine(typeof(_003CRangedWeaponRoutine_003Ed__59))]
		private IEnumerator RangedWeaponRoutine()
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

		private void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
		}

		private void ProcessThirdPartyVisionEvent(VisionEventReceipt visionEventReceipt)
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

		private void SetArrestCircleColor(Color col)
		{
		}

		private void StartSearching()
		{
		}

		private void StopSearching()
		{
		}

		[IteratorStateMachine(typeof(_003CSearchRoutine_003Ed__82))]
		private IEnumerator SearchRoutine()
		{
			return null;
		}

		private Vector3 GetNextSearchLocation()
		{
			return default(Vector3);
		}

		private Vector3 GetRandomReachablePointNear(Vector3 point, float randomRadius, float minDistance = 0f)
		{
			return default(Vector3);
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

		private void RpcWriter___Observers_AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
		}

		public virtual void RpcLogic___AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
		}

		private void RpcReader___Observers_AssignTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002ENPCs_002EBehaviour_002EPursuitBehaviour(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EPursuitBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
