namespace ScheduleOne.Vehicles
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.BoxCollider))]
	public class PlayerPusher : global::UnityEngine.MonoBehaviour
	{
		private global::ScheduleOne.Vehicles.LandVehicle veh;

		[global::UnityEngine.Header("Settings")]
		public float MinSpeedToPush;

		public float MaxPushSpeed;

		public float MinPushForce;

		public float MaxPushForce;

		private global::UnityEngine.Collider collider;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetEnabled(bool isEnabled)
		{
		}

		private void OnTriggerStay(global::UnityEngine.Collider other)
		{
		}
	}
}
