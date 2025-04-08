namespace ScheduleOne.NPCs.Behaviour
{
	public class FootPatrolRoute : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public string RouteName;

		public global::UnityEngine.Color PathColor;

		public global::UnityEngine.Transform[] Waypoints;

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
