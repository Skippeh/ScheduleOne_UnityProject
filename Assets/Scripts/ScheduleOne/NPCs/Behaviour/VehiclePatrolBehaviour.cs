using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.AI;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class VehiclePatrolBehaviour : Behaviour
	{
		public new const float MAX_CONSECUTIVE_PATHING_FAILURES = 5f;

		public const float PROGRESSION_THRESHOLD = 10f;

		public int CurrentWaypoint;

		[Header("Settings")]
		public VehiclePatrolRoute Route;

		public LandVehicle Vehicle;

		private bool aggressiveDrivingEnabled;

		private new int consecutivePathingFailures;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EVehiclePatrolBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EVehiclePatrolBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool isDriving => false;

		private VehicleAgent Agent => null;

		public override void Awake()
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

		public void SetRoute(VehiclePatrolRoute route)
		{
		}

		private void StartPatrol()
		{
		}

		public override void ActiveMinPass()
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
