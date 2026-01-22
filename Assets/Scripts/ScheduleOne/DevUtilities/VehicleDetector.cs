namespace ScheduleOne.DevUtilities
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class VehicleDetector : global::UnityEngine.MonoBehaviour
	{
		public const float ACTIVATION_DISTANCE_SQ = 400f;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.LandVehicle> vehicles;

		public global::ScheduleOne.Vehicles.LandVehicle closestVehicle;

		private bool ignoreExit;

		private global::UnityEngine.Collider[] detectionColliders;

		private bool collidersEnabled;

		public bool IgnoreNewDetections { get; protected set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}

		private void OnTick()
		{
		}

		private void OnTriggerExit(global::UnityEngine.Collider other)
		{
		}

		private void SortVehicles()
		{
		}

		public void SetIgnoreNewCollisions(bool ignore)
		{
		}

		public bool AreAnyVehiclesOccupied()
		{
			return false;
		}

		public void Clear()
		{
		}
	}
}
