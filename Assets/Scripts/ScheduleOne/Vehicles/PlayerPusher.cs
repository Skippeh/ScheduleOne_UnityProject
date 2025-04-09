using UnityEngine;

namespace ScheduleOne.Vehicles
{
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(BoxCollider))]
	public class PlayerPusher : MonoBehaviour
	{
		private LandVehicle veh;

		[Header("Settings")]
		public float MinSpeedToPush;

		public float MaxPushSpeed;

		public float MinPushForce;

		public float MaxPushForce;

		private Collider collider;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}
	}
}
