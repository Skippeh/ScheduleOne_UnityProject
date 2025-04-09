using ScheduleOne.Map;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.AI;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	public class NPCSignal_DriveToCarPark : NPCSignal
	{
		public ParkingLot ParkingLot;

		public LandVehicle Vehicle;

		[Header("Parking Settings")]
		public bool OverrideParkingType;

		public EParkingAlignment ParkingType;

		private bool isAtDestination;

		private float timeInVehicle;

		private float timeAtDestination;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCSignal_DriveToCarParkAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCSignal_DriveToCarParkAssembly_002DCSharp_002Edll_Excuted;

		public new string ActionName => null;

		public override string GetName()
		{
			return null;
		}

		protected override void OnValidate()
		{
		}

		public override void Started()
		{
		}

		public override void End()
		{
		}

		public override void LateStarted()
		{
		}

		private void CheckValidForStart()
		{
		}

		public override void Interrupt()
		{
		}

		public override void Resume()
		{
		}

		public override void Skipped()
		{
		}

		public override void ResumeFailed()
		{
		}

		public override void JumpTo()
		{
		}

		public override void ActiveMinPassed()
		{
		}

		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		private Vector3 GetWalkDestination()
		{
			return default(Vector3);
		}

		private void DriveCallback(VehicleAgent.ENavigationResult result)
		{
		}

		private void Park()
		{
		}

		private EParkingAlignment GetParkingType()
		{
			return default(EParkingAlignment);
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

		public override void Awake()
		{
		}
	}
}
