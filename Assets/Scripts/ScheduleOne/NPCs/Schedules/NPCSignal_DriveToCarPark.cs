namespace ScheduleOne.NPCs.Schedules
{
	public class NPCSignal_DriveToCarPark : global::ScheduleOne.NPCs.Schedules.NPCSignal
	{
		public global::ScheduleOne.Map.ParkingLot ParkingLot;

		public global::ScheduleOne.Vehicles.LandVehicle Vehicle;

		[global::UnityEngine.Header("Parking Settings")]
		public bool OverrideParkingType;

		public global::ScheduleOne.Vehicles.EParkingAlignment ParkingType;

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

		public override void OnActiveTick()
		{
		}

		protected override void WalkCallback(global::ScheduleOne.NPCs.NPCMovement.WalkResult result)
		{
		}

		private global::UnityEngine.Vector3 GetWalkDestination()
		{
			return default(global::UnityEngine.Vector3);
		}

		private void DriveCallback(global::ScheduleOne.Vehicles.AI.VehicleAgent.ENavigationResult result)
		{
		}

		private void Park()
		{
		}

		private global::ScheduleOne.Vehicles.EParkingAlignment GetParkingType()
		{
			return default(global::ScheduleOne.Vehicles.EParkingAlignment);
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
