namespace ScheduleOne.Map
{
	public class ParkingSpot : global::UnityEngine.MonoBehaviour
	{
		private global::ScheduleOne.Map.ParkingLot ParentLot;

		public global::UnityEngine.Transform AlignmentPoint;

		public global::ScheduleOne.Vehicles.EParkingAlignment Alignment;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Vehicles.LandVehicle OccupantVehicle_Readonly;

		public global::ScheduleOne.Vehicles.LandVehicle OccupantVehicle { get; protected set; }

		private void Awake()
		{
		}

		private void Init()
		{
		}

		public void SetOccupant(global::ScheduleOne.Vehicles.LandVehicle vehicle)
		{
		}
	}
}
