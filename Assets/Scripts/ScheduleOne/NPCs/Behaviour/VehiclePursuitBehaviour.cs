using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.AI;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class VehiclePursuitBehaviour : Behaviour
	{
		public new const float MAX_CONSECUTIVE_PATHING_FAILURES = 5f;

		public const float EXTRA_VISIBILITY_TIME = 6f;

		public const float EXIT_VEHICLE_MAX_SPEED = 4f;

		public const float CLOSE_ENOUGH_THRESHOLD = 10f;

		public const float UPDATE_FREQUENCY = 0.2f;

		public const float STATIONARY_THRESHOLD = 1f;

		public const float TIME_STATIONARY_TO_EXIT = 3f;

		[Header("Settings")]
		public AnimationCurve RepathDistanceThresholdMap;

		public LandVehicle vehicle;

		private bool initialContactMade;

		private bool aggressiveDrivingEnabled;

		private bool isTargetVisible;

		private bool isTargetStrictlyVisible;

		private float playerSightedDuration;

		private float timeSinceLastSighting;

		private new int consecutivePathingFailures;

		private float timeStationary;

		private Vector3 currentDriveTarget;

		private int targetChanges;

		private float timeSincePursuitStart;

		private bool beginAsSighted;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EVehiclePursuitBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EVehiclePursuitBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public Player TargetPlayer { get; protected set; }

		private bool isDriving => false;

		private VehicleAgent Agent => null;

		public override void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void BeginAsSighted()
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

		public virtual void AssignTarget(Player target)
		{
		}

		private void StartPursuit()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		public override void ActiveMinPass()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		private void UpdateDestination()
		{
		}

		private bool IsTargetValid()
		{
			return false;
		}

		private void CheckExitVehicle()
		{
		}

		private Vector3 GetPlayerChasePoint()
		{
			return default(Vector3);
		}

		private void SetAggressiveDriving(bool aggressive)
		{
		}

		private void DriveTo(Vector3 location)
		{
		}

		private void NavigationCallback(VehicleAgent.ENavigationResult status)
		{
		}

		private bool IsAsCloseAsPossible(Vector3 pos, out Vector3 closestPosition)
		{
			closestPosition = default(Vector3);
			return false;
		}

		private bool IsPlayerVisible()
		{
			return false;
		}

		private void CheckPlayerVisibility()
		{
		}

		private void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
		}

		private void ProcessThirdPartyVisionEvent(VisionEventReceipt visionEventReceipt)
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EVehiclePursuitBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
