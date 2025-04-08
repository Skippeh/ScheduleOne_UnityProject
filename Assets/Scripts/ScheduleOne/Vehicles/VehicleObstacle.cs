namespace ScheduleOne.Vehicles
{
	public class VehicleObstacle : global::UnityEngine.MonoBehaviour
	{
		public enum EObstacleType
		{
			Generic = 0,
			TrafficLight = 1
		}

		public global::UnityEngine.Collider col;

		[global::UnityEngine.Header("Settings")]
		public bool twoSided;

		public global::ScheduleOne.Vehicles.VehicleObstacle.EObstacleType type;
	}
}
