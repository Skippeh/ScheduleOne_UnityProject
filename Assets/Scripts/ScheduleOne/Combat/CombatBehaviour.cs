using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.Combat
{
	public class CombatBehaviour : ScheduleOne.NPCs.Behaviour.Behaviour
	{
		[CompilerGenerated]
		private sealed class _003CSearchRoutine_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CombatBehaviour _003C_003E4__this;

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
			public _003CSearchRoutine_003Ed__68(int _003C_003E1__state)
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

		public const float EXTRA_VISIBILITY_TIME = 2.5f;

		public const float SEARCH_RADIUS_MIN = 25f;

		public const float SEARCH_RADIUS_MAX = 60f;

		public const float SEARCH_SPEED = 0.4f;

		public const float CONSECUTIVE_MISS_ACCURACY_BOOST = 0.1f;

		public const float REACHED_DESTINATION_DISTANCE = 2f;

		[Header("General Setttings")]
		public float GiveUpRange;

		public float GiveUpTime;

		public int GiveUpAfterSuccessfulHits;

		public bool PlayAngryVO;

		[Header("Movement settings")]
		[Range(0f, 1f)]
		public float DefaultMovementSpeed;

		[Header("Weapon settings")]
		public AvatarWeapon DefaultWeapon;

		public AvatarMeleeWeapon VirtualPunchWeapon;

		[Header("Search settings")]
		public float DefaultSearchTime;

		protected bool overrideTargetDistance;

		protected float targetDistanceOverride;

		protected bool isTargetRecentlyVisible;

		protected bool isTargetImmediatelyVisible;

		protected float timeSinceLastSighting;

		protected float playerSightedDuration;

		protected Vector3 lastKnownTargetPosition;

		protected AvatarWeapon currentWeapon;

		protected int successfulHits;

		protected int consecutiveMissedShots;

		protected Coroutine rangedWeaponRoutine;

		protected Coroutine searchRoutine;

		protected Vector3 currentSearchDestination;

		protected bool hasSearchDestination;

		private float nextAngryVO;

		private bool NetworkInitialize___EarlyScheduleOne_002ECombat_002ECombatBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECombat_002ECombatBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public Player TargetPlayer { get; protected set; }

		public bool IsSearching { get; protected set; }

		public float TimeSinceTargetReacquired { get; protected set; }

		public override void Awake()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public virtual void SetTarget(NetworkConnection conn, NetworkObject target)
		{
		}

		protected override void Begin()
		{
		}

		protected override void Resume()
		{
		}

		protected override void Pause()
		{
		}

		protected override void End()
		{
		}

		public override void Disable()
		{
		}

		protected virtual void StartCombat()
		{
		}

		protected void EndCombat()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected void UpdateTimeout()
		{
		}

		protected virtual void UpdateLookAt()
		{
		}

		protected void SetMovementSpeed(float speed)
		{
		}

		[ObserversRpc(RunLocally = true)]
		protected virtual void SetWeapon(string weaponPath)
		{
		}

		[ObserversRpc(RunLocally = true)]
		protected void ClearWeapon()
		{
		}

		protected virtual bool ReadyToAttack(bool checkTarget = true)
		{
			return false;
		}

		[ObserversRpc(RunLocally = true)]
		protected virtual void Attack()
		{
		}

		protected void SucessfulHit()
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

		[IteratorStateMachine(typeof(_003CSearchRoutine_003Ed__68))]
		private IEnumerator SearchRoutine()
		{
			return null;
		}

		private Vector3 GetNextSearchLocation()
		{
			return default(Vector3);
		}

		protected bool IsTargetValid()
		{
			return false;
		}

		private void RepositionToTargetRange(Vector3 origin)
		{
		}

		private Vector3 GetRandomReachablePointNear(Vector3 point, float randomRadius, float minDistance = 0f)
		{
			return default(Vector3);
		}

		protected float GetMinTargetDistance()
		{
			return 0f;
		}

		protected float GetMaxTargetDistance()
		{
			return 0f;
		}

		protected bool IsTargetInRange(Vector3 origin = default(Vector3))
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

		private void RpcWriter___Observers_SetTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
		}

		public virtual void RpcLogic___SetTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
		}

		private void RpcReader___Observers_SetTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetWeapon_3615296227(string weaponPath)
		{
		}

		protected virtual void RpcLogic___SetWeapon_3615296227(string weaponPath)
		{
		}

		private void RpcReader___Observers_SetWeapon_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ClearWeapon_2166136261()
		{
		}

		protected void RpcLogic___ClearWeapon_2166136261()
		{
		}

		private void RpcReader___Observers_ClearWeapon_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_Attack_2166136261()
		{
		}

		protected virtual void RpcLogic___Attack_2166136261()
		{
		}

		private void RpcReader___Observers_Attack_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ECombat_002ECombatBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
