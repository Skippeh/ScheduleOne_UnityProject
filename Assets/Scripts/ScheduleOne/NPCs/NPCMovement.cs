namespace ScheduleOne.NPCs
{
	public class NPCMovement : global::FishNet.Object.NetworkBehaviour
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

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CFaceDirection_Process_003Ed__154 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float lerpTime;

			public global::ScheduleOne.NPCs.NPCMovement _003C_003E4__this;

			public global::UnityEngine.Vector3 forward;

			private global::UnityEngine.Quaternion _003CstartRot_003E5__2;

			private float _003Ci_003E5__3;

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
			public _003CFaceDirection_Process_003Ed__154(int _003C_003E1__state)
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

		public static global::System.Collections.Generic.Dictionary<global::UnityEngine.Vector3, global::UnityEngine.Vector3> cachedClosestReachablePoints;

		public static global::System.Collections.Generic.List<global::UnityEngine.Vector3> cachedClosestPointKeys;

		public const float CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET = 1f;

		public bool DEBUG;

		[global::UnityEngine.Header("Settings")]
		public float WalkSpeed;

		public float RunSpeed;

		public float MoveSpeedMultiplier;

		[global::UnityEngine.Header("Obstacle Avoidance")]
		public bool ObstacleAvoidanceEnabled;

		public global::UnityEngine.AI.ObstacleAvoidanceType DefaultObstacleAvoidanceType;

		[global::UnityEngine.Header("Slippery Mode")]
		public bool SlipperyMode;

		public float SlipperyModeMultiplier;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.AI.NavMeshAgent Agent;

		public global::ScheduleOne.NPCs.NPCSpeedController SpeedController;

		public global::UnityEngine.CapsuleCollider CapsuleCollider;

		public global::ScheduleOne.NPCs.NPCAnimation Animation;

		public global::ScheduleOne.Tools.SmoothedVelocityCalculator VelocityCalculator;

		public global::ScheduleOne.Dragging.Draggable RagdollDraggable;

		public global::UnityEngine.Collider RagdollDraggableCollider;

		protected global::ScheduleOne.NPCs.NPC npc;

		public float MovementSpeedScale;

		private float ragdollStaticTime;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Vehicles.LandVehicle> onHitByCar;

		public global::UnityEngine.Events.UnityEvent onRagdollStart;

		public global::UnityEngine.Events.UnityEvent onRagdollEnd;

		private bool cacheNextPath;

		private global::UnityEngine.Vector3 currentDestination_Reachable;

		private global::System.Action<global::ScheduleOne.NPCs.NPCMovement.WalkResult> walkResultCallback;

		private float currentMaxDistanceForSuccess;

		private bool forceIsMoving;

		private global::UnityEngine.Coroutine faceDirectionRoutine;

		private global::System.Collections.Generic.List<global::UnityEngine.ConstantForce> ragdollForceComponents;

		private float timeUntilNextStumble;

		private float timeSinceStumble;

		private global::UnityEngine.Vector3 stumbleDirection;

		private CircularQueue<global::UnityEngine.Vector3> desiredVelocityHistory;

		private int desiredVelocityHistoryLength;

		private float velocityHistorySpacing;

		private float timeSinceLastVelocityHistoryRecord;

		private global::UnityEngine.AI.NavMeshPath agentCurrentPath;

		private float agentCurrentSpeed;

		private global::UnityEngine.Vector3[] agentCurrentPathCorners;

		private global::UnityEngine.Coroutine ladderClimbRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ENPCMovementAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ENPCMovementAssembly_002DCSharp_002Edll_Excuted;

		public bool HasDestination { get; protected set; }

		public bool IsMoving => false;

		public bool IsPaused { get; protected set; }

		public global::UnityEngine.Vector3 FootPosition => default(global::UnityEngine.Vector3);

		public float GravityMultiplier { get; protected set; }

		public global::ScheduleOne.NPCs.NPCMovement.EStance Stance { get; protected set; }

		public float TimeSinceHitByCar { get; protected set; }

		public bool FaceDirectionInProgress => false;

		public bool IsOnLadder => false;

		public float CurrentLadderSpeed { get; protected set; }

		public bool IsClimbingUpwards => false;

		public global::ScheduleOne.Map.Ladder CurrentLadder { get; protected set; }

		public global::UnityEngine.Vector3 CurrentDestination { get; protected set; }

		public global::ScheduleOne.NPCs.NPCPathCache PathCache { get; private set; }

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

		protected virtual void Update()
		{
		}

		public void SetAgentEnabled(bool enabled)
		{
		}

		private void UpdateRagdoll()
		{
		}

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

		public void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}

		public void OnCollisionEnter(global::UnityEngine.Collision collision)
		{
		}

		private void CheckHit(global::UnityEngine.Collider other, global::UnityEngine.Collider thisCollider, bool isCollision, global::UnityEngine.Vector3 hitPoint)
		{
		}

		public void Warp(global::UnityEngine.Transform target)
		{
		}

		public void Warp(global::UnityEngine.Vector3 position)
		{
		}

		[global::FishNet.Object.ObserversRpc(ExcludeServer = true)]
		private void ReceiveWarp(global::UnityEngine.Vector3 position)
		{
		}

		public void VisibilityChange(bool visible)
		{
		}

		public bool CanMove()
		{
			return false;
		}

		public void SetAgentType(global::ScheduleOne.NPCs.NPCMovement.EAgentType type)
		{
		}

		public void SetSeat(global::ScheduleOne.AvatarFramework.Animation.AvatarSeat seat)
		{
		}

		public void SetStance(global::ScheduleOne.NPCs.NPCMovement.EStance stance)
		{
		}

		public void SetGravityMultiplier(float multiplier)
		{
		}

		public void SetRagdollDraggable(bool draggable)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void ActivateRagdoll_Server()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void ActivateRagdoll(global::UnityEngine.Vector3 forcePoint, global::UnityEngine.Vector3 forceDir, float forceMagnitude)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void ApplyRagdollForce(global::UnityEngine.Vector3 forcePoint, global::UnityEngine.Vector3 forceDir, float forceMagnitude)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void DeactivateRagdoll()
		{
		}

		private bool SmartSampleNavMesh(global::UnityEngine.Vector3 position, out global::UnityEngine.AI.NavMeshHit hit, float minRadius = 1f, float maxRadius = 10f, int steps = 3)
		{
			hit = default(global::UnityEngine.AI.NavMeshHit);
			return false;
		}

		public void SetDestination(global::UnityEngine.Transform target)
		{
		}

		public void SetDestination(global::UnityEngine.Vector3 pos)
		{
		}

		public void SetDestination(global::ScheduleOne.Management.ITransitEntity entity)
		{
		}

		public void SetDestination(global::UnityEngine.Vector3 pos, global::System.Action<global::ScheduleOne.NPCs.NPCMovement.WalkResult> callback = null, float maximumDistanceForSuccess = 1f, float cacheMaxDistSqr = 1f)
		{
		}

		private void SetDestination(global::UnityEngine.Vector3 pos, global::System.Action<global::ScheduleOne.NPCs.NPCMovement.WalkResult> callback = null, bool interruptExistingCallback = true, float successThreshold = 1f, float cacheMaxDistSqr = 1f)
		{
		}

		private bool IsNPCPositionValid(global::UnityEngine.Vector3 position)
		{
			return false;
		}

		private void EndSetDestination(global::ScheduleOne.NPCs.NPCMovement.WalkResult result)
		{
		}

		public void Stop()
		{
		}

		public void WarpToNavMesh()
		{
		}

		public void FacePoint(global::UnityEngine.Vector3 point, float lerpTime = 0.5f)
		{
		}

		public void FaceDirection(global::UnityEngine.Vector3 forward, float lerpTime = 0.5f)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.NPCs.NPCMovement._003CFaceDirection_Process_003Ed__154))]
		protected global::System.Collections.IEnumerator FaceDirection_Process(global::UnityEngine.Vector3 forward, float lerpTime)
		{
			return null;
		}

		public void PauseMovement()
		{
		}

		public void ResumeMovement()
		{
		}

		public bool IsAsCloseAsPossible(global::UnityEngine.Vector3 location, float distanceThreshold = 0.5f)
		{
			return false;
		}

		public bool GetClosestReachablePoint(global::UnityEngine.Vector3 targetPosition, out global::UnityEngine.Vector3 closestPoint)
		{
			closestPoint = default(global::UnityEngine.Vector3);
			return false;
		}

		public bool CanGetTo(global::UnityEngine.Vector3 position, float proximityReq = 1f)
		{
			return false;
		}

		public bool CanGetTo(global::ScheduleOne.Management.ITransitEntity entity, float proximityReq = 1f)
		{
			return false;
		}

		public bool CanGetTo(global::UnityEngine.Vector3 position, float proximityReq, out global::UnityEngine.AI.NavMeshPath path)
		{
			path = null;
			return false;
		}

		private global::UnityEngine.AI.NavMeshPath GetPathTo(global::UnityEngine.Vector3 position, float proximityReq = 1f)
		{
			return null;
		}

		public void TraverseLadder(global::ScheduleOne.Map.Ladder ladder)
		{
		}

		private void CancelTraverseLadder()
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

		private void RpcWriter___Observers_ReceiveWarp_4276783012(global::UnityEngine.Vector3 position)
		{
		}

		private void RpcLogic___ReceiveWarp_4276783012(global::UnityEngine.Vector3 position)
		{
		}

		private void RpcReader___Observers_ReceiveWarp_4276783012(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ActivateRagdoll_Server_2166136261()
		{
		}

		public void RpcLogic___ActivateRagdoll_Server_2166136261()
		{
		}

		private void RpcReader___Server_ActivateRagdoll_Server_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ActivateRagdoll_2690242654(global::UnityEngine.Vector3 forcePoint, global::UnityEngine.Vector3 forceDir, float forceMagnitude)
		{
		}

		public void RpcLogic___ActivateRagdoll_2690242654(global::UnityEngine.Vector3 forcePoint, global::UnityEngine.Vector3 forceDir, float forceMagnitude)
		{
		}

		private void RpcReader___Observers_ActivateRagdoll_2690242654(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ApplyRagdollForce_2690242654(global::UnityEngine.Vector3 forcePoint, global::UnityEngine.Vector3 forceDir, float forceMagnitude)
		{
		}

		public void RpcLogic___ApplyRagdollForce_2690242654(global::UnityEngine.Vector3 forcePoint, global::UnityEngine.Vector3 forceDir, float forceMagnitude)
		{
		}

		private void RpcReader___Observers_ApplyRagdollForce_2690242654(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_DeactivateRagdoll_2166136261()
		{
		}

		public void RpcLogic___DeactivateRagdoll_2166136261()
		{
		}

		private void RpcReader___Observers_DeactivateRagdoll_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ENPCMovement_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
