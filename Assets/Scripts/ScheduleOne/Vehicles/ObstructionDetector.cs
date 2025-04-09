using System.Collections.Generic;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	[RequireComponent(typeof(Rigidbody))]
	public class ObstructionDetector : MonoBehaviour
	{
		private LandVehicle vehicle;

		public List<LandVehicle> vehicles;

		public List<NPC> npcs;

		public List<PlayerMovement> players;

		public List<VehicleObstacle> vehicleObstacles;

		public float closestObstructionDistance;

		public float range;

		protected virtual void Awake()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}
	}
}
