namespace ScheduleOne.Map
{
	public class ParkingLot : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable
	{
		[global::UnityEngine.SerializeField]
		protected string BakedGUID;

		[global::UnityEngine.Header("READONLY")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Map.ParkingSpot> ParkingSpots;

		[global::UnityEngine.Header("Entry")]
		public global::UnityEngine.Transform EntryPoint;

		public global::UnityEngine.Transform HiddenVehicleAccessPoint;

		[global::UnityEngine.Header("Exit")]
		public bool UseExitPoint;

		public global::ScheduleOne.Vehicles.EParkingAlignment ExitAlignment;

		public global::UnityEngine.Transform ExitPoint;

		public global::ScheduleOne.DevUtilities.VehicleDetector ExitPointVehicleDetector;

		public global::System.Guid GUID { get; protected set; }

		private void Awake()
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		public global::ScheduleOne.Map.ParkingSpot GetRandomFreeSpot()
		{
			return null;
		}

		public int GetRandomFreeSpotIndex()
		{
			return 0;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Map.ParkingSpot> GetFreeParkingSpots()
		{
			return null;
		}
	}
}
