using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.Dragging;
using ScheduleOne.Management;
using ScheduleOne.Tools;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	public class NPCMovement : NetworkBehaviour
	{
		public enum EAgentType
		{
			Humanoid = 0,
			BigHumanoid = 1,
			IgnoreCosts = 2
		}

		public enum EStance
		{
			None = 0,
			Stanced = 1
		}

		public enum WalkResult
		{
			Failed = 0,
			Interrupted = 1,
			Stopped = 2,
			Partial = 3,
			Success = 4
		}

		[CompilerGenerated]
		private sealed class _003CFaceDirection_Process_003Ed__139 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float lerpTime;

			public NPCMovement _003C_003E4__this;

			public Vector3 forward;

			private Quaternion _003CstartRot_003E5__2;

			private float _003Ci_003E5__3;

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
			public _003CFaceDirection_Process_003Ed__139(int _003C_003E1__state)
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

		public const float VEHICLE_RUNOVER_THRESHOLD = 10f;

		public const float SKATEBOARD_RUNOVER_THRESHOLD = 10f;

		public const float LIGHT_FLINCH_THRESHOLD = 50f;

		public const float HEAVY_FLINCH_THRESHOLD = 100f;

		public const float RAGDOLL_THRESHOLD = 150f;

		public const float MOMENTUM_ANNOYED_THRESHOLD = 10f;

		public const float MOMENTUM_LIGHT_FLINCH_THRESHOLD = 20f;

		public const float MOMENTUM_HEAVY_FLINCH_THRESHOLD = 40f;

		public const float MOMENTUM_RAGDOLL_THRESHOLD = 60f;

		public const bool USE_PATH_CACHE = true;

		public const float STUMBLE_DURATION = 0.66f;

		public const float STUMBLE_FORCE = 7f;

		public const float OBSTACLE_AVOIDANCE_RANGE = 25f;

		public const float PLAYER_DIST_IMPACT_THRESHOLD = 30f;

		public static Dictionary<Vector3, Vector3> cachedClosestReachablePoints;

		public static List<Vector3> cachedClosestPointKeys;

		public const float CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET = 1f;

		public bool DEBUG;

		[Header("Settings")]
		public float WalkSpeed;

		public float RunSpeed;

		public float MoveSpeedMultiplier;

		public bool SlipperyMode;

		public float SlipperyModeMultiplier;

		public ObstacleAvoidanceType DefaultObstacleAvoidanceType;

		[Header("References")]
		public NavMeshAgent Agent;

		public NPCSpeedController SpeedController;

		protected NPC npc;

		public CapsuleCollider capsuleCollider;

		[SerializeField]
		protected NPCAnimation anim;

		[SerializeField]
		protected Rigidbody ragdollCentralRB;

		public SmoothedVelocityCalculator velocityCalculator;

		[SerializeField]
		protected Draggable RagdollDraggable;

		[SerializeField]
		protected Collider RagdollDraggableCollider;

		public float MovementSpeedScale;

		private float ragdollTime;

		private float ragdollStaticTime;

		public UnityEvent<LandVehicle> onHitByCar;

		public UnityEvent onRagdollStart;

		public UnityEvent onRagdollEnd;

		private bool cacheNextPath;

		private Vector3 currentDestination_Reachable;

		private Action<WalkResult> walkResultCallback;

		private float currentMaxDistanceForSuccess;

		private bool forceIsMoving;

		private Coroutine FaceDirectionRoutine;

		private List<ConstantForce> ragdollForceComponents;

		private float timeUntilNextStumble;

		private float timeSinceStumble;

		private Vector3 stumbleDirection;

		private List<Vector3> desiredVelocityHistory;

		private int desiredVelocityHistoryLength;

		private float velocityHistorySpacing;

		private float timeSinceLastVelocityHistoryRecord;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ENPCMovementAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ENPCMovementAssembly_002DCSharp_002Edll_Excuted;

		public bool hasDestination { get; protected set; }

		public bool IsMoving => false;

		public bool IsPaused { get; protected set; }

		public Vector3 FootPosition => default(Vector3);

		public float GravityMultiplier { get; protected set; }

		public EStance Stance { get; protected set; }

		public float timeSinceHitByCar { get; protected set; }

		public bool FaceDirectionInProgress => false;

		public Vector3 CurrentDestination { get; protected set; }

		public NPCPathCache PathCache { get; private set; }

		public bool Disoriented { get; set; }

		public virtual void Awake()
		{
		}

		private void Start()
		{
		}

		public override void OnStartClient()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void UpdateRagdoll()
		{
		}

		[Button]
		private void Stumble()
		{
		}

		private void UpdateDestination()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		private void UpdateStumble()
		{
		}

		private void UpdateSpeed()
		{
		}

		private void RecordVelocity()
		{
		}

		private void UpdateSlippery()
		{
		}

		private void UpdateCache()
		{
		}

		public bool CanRecoverFromRagdoll()
		{
			return false;
		}

		private void UpdateAvoidance()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		public void OnCollisionEnter(Collision collision)
		{
		}

		private void CheckHit(Collider other, Collider thisCollider, bool isCollision, Vector3 hitPoint)
		{
		}

		public void Warp(Transform target)
		{
		}

		public void Warp(Vector3 position)
		{
		}

		[ObserversRpc(ExcludeServer = true)]
		private void ReceiveWarp(Vector3 position)
		{
		}

		public void VisibilityChange(bool visible)
		{
		}

		public bool CanMove()
		{
			return false;
		}

		public void SetAgentType(EAgentType type)
		{
		}

		public void SetSeat(AvatarSeat seat)
		{
		}

		public void SetStance(EStance stance)
		{
		}

		public void SetGravityMultiplier(float multiplier)
		{
		}

		public void SetRagdollDraggable(bool draggable)
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void ActivateRagdoll_Server()
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void ActivateRagdoll(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void ApplyRagdollForce(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void DeactivateRagdoll()
		{
		}

		private bool SmartSampleNavMesh(Vector3 position, out NavMeshHit hit, float minRadius = 1f, float maxRadius = 10f, int steps = 3)
		{
			hit = default(NavMeshHit);
			return false;
		}

		public void SetDestination(Vector3 pos)
		{
		}

		public void SetDestination(ITransitEntity entity)
		{
		}

		public void SetDestination(Vector3 pos, Action<WalkResult> callback = null, float maximumDistanceForSuccess = 1f, float cacheMaxDistSqr = 1f)
		{
		}

		private void SetDestination(Vector3 pos, Action<WalkResult> callback = null, bool interruptExistingCallback = true, float successThreshold = 1f, float cacheMaxDistSqr = 1f)
		{
		}

		private bool IsNPCPositionValid(Vector3 position)
		{
			return false;
		}

		private void EndSetDestination(WalkResult result)
		{
		}

		public void Stop()
		{
		}

		public void WarpToNavMesh()
		{
		}

		public void FacePoint(Vector3 point, float lerpTime = 0.5f)
		{
		}

		public void FaceDirection(Vector3 forward, float lerpTime = 0.5f)
		{
		}

		[IteratorStateMachine(typeof(_003CFaceDirection_Process_003Ed__139))]
		protected IEnumerator FaceDirection_Process(Vector3 forward, float lerpTime)
		{
			return null;
		}

		public void PauseMovement()
		{
		}

		public void ResumeMovement()
		{
		}

		public bool IsAsCloseAsPossible(Vector3 location, float distanceThreshold = 0.5f)
		{
			return false;
		}

		public bool GetClosestReachablePoint(Vector3 targetPosition, out Vector3 closestPoint)
		{
			closestPoint = default(Vector3);
			return false;
		}

		public bool CanGetTo(Vector3 position, float proximityReq = 1f)
		{
			return false;
		}

		public bool CanGetTo(ITransitEntity entity, float proximityReq = 1f)
		{
			return false;
		}

		public bool CanGetTo(Vector3 position, float proximityReq, out NavMeshPath path)
		{
			path = null;
			return false;
		}

		private NavMeshPath GetPathTo(Vector3 position, float proximityReq = 1f)
		{
			return null;
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

		private void RpcWriter___Observers_ReceiveWarp_4276783012(Vector3 position)
		{
		}

		private void RpcLogic___ReceiveWarp_4276783012(Vector3 position)
		{
		}

		private void RpcReader___Observers_ReceiveWarp_4276783012(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_ActivateRagdoll_Server_2166136261()
		{
		}

		public void RpcLogic___ActivateRagdoll_Server_2166136261()
		{
		}

		private void RpcReader___Server_ActivateRagdoll_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		public void RpcLogic___ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		private void RpcReader___Observers_ActivateRagdoll_2690242654(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		public void RpcLogic___ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		private void RpcReader___Observers_ApplyRagdollForce_2690242654(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_DeactivateRagdoll_2166136261()
		{
		}

		public void RpcLogic___DeactivateRagdoll_2166136261()
		{
		}

		private void RpcReader___Observers_DeactivateRagdoll_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ENPCMovement_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
