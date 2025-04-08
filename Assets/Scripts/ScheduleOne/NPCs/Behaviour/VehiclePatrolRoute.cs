namespace ScheduleOne.NPCs.Behaviour
{
	public class VehiclePatrolRoute : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public string RouteName;

		public global::UnityEngine.Transform[] Waypoints;

		public int StartWaypointIndex;

		private void OnDrawGizmos()
		{
		}
	}
}
