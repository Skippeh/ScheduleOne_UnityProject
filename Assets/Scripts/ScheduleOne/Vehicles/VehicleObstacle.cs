using UnityEngine;

namespace ScheduleOne.Vehicles
{
	public class VehicleObstacle : MonoBehaviour
	{
		public enum EObstacleType
		{
			Generic = 0,
			TrafficLight = 1
		}

		public Collider col;

		[Header("Settings")]
		public bool twoSided;

		public EObstacleType type;
	}
}
