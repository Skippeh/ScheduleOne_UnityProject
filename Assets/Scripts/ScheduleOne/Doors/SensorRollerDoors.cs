namespace ScheduleOne.Doors
{
	public class SensorRollerDoors : global::ScheduleOne.Doors.RollerDoor
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.DevUtilities.VehicleDetector Detector;

		public global::ScheduleOne.DevUtilities.VehicleDetector ClipDetector;

		[global::UnityEngine.Header("Settings")]
		public bool DetectPlayerOccupiedVehiclesOnly;

		protected virtual void Update()
		{
		}
	}
}
