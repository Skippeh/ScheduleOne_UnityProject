using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class VehiclePatrolRoute : MonoBehaviour
	{
		[Header("Settings")]
		public string RouteName;

		public Transform[] Waypoints;

		public int StartWaypointIndex;

		private void OnDrawGizmos()
		{
		}
	}
}
