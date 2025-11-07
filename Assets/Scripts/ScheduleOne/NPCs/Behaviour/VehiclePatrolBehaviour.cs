namespace ScheduleOne.NPCs.Behaviour
{
	public class VehiclePatrolBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public new const float MAX_CONSECUTIVE_PATHING_FAILURES = 5f;

		public const float PROGRESSION_THRESHOLD = 10f;

		public int CurrentWaypoint;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.NPCs.Behaviour.VehiclePatrolRoute Route;

		public global::ScheduleOne.Vehicles.LandVehicle Vehicle;

		private bool aggressiveDrivingEnabled;

		private new int consecutivePathingFailures;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EVehiclePatrolBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EVehiclePatrolBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool isDriving => false;

		private global::ScheduleOne.Vehicles.AI.VehicleAgent Agent => null;

		public override void Awake()
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

		public void SetRoute(global::ScheduleOne.NPCs.Behaviour.VehiclePatrolRoute route)
		{
		}

		private void StartPatrol()
		{
		}

		public override void ActiveMinPass()
		{
		}

		private void DriveTo(global::UnityEngine.Vector3 location)
		{
		}

		private void NavigationCallback(global::ScheduleOne.Vehicles.AI.VehicleAgent.ENavigationResult status)
		{
		}

		private bool IsAsCloseAsPossible(global::UnityEngine.Vector3 pos, out global::UnityEngine.Vector3 closestPosition)
		{
			closestPosition = default(global::UnityEngine.Vector3);
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EVehiclePatrolBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
