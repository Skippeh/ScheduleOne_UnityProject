using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class FootPatrolRoute : MonoBehaviour
	{
		[Header("Settings")]
		public string RouteName;

		public Color PathColor;

		public Transform[] Waypoints;

		public int StartWaypointIndex;

		private void OnDrawGizmos()
		{
		}

		private void OnValidate()
		{
		}

		private void UpdateWaypoints()
		{
		}
	}
}
