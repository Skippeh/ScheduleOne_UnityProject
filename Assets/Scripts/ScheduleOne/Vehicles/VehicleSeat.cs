namespace ScheduleOne.Vehicles
{
	public class VehicleSeat : global::UnityEngine.MonoBehaviour
	{
		public bool isDriverSeat;

		public global::ScheduleOne.PlayerScripts.Player Occupant;

		public bool isOccupied => false;
	}
}
