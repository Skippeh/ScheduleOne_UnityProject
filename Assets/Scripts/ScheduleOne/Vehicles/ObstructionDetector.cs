namespace ScheduleOne.Vehicles
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class ObstructionDetector : global::UnityEngine.MonoBehaviour
	{
		private global::ScheduleOne.Vehicles.LandVehicle vehicle;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.LandVehicle> vehicles;

		public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> npcs;

		public global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.PlayerMovement> players;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.VehicleObstacle> vehicleObstacles;

		public float closestObstructionDistance;

		public float range;

		protected virtual void Awake()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		private void OnTriggerStay(global::UnityEngine.Collider other)
		{
		}
	}
}
