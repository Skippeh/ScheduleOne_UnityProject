namespace ScheduleOne.Tools
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.NPCs.NPCMovement))]
	public class NPCWalkTo : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Transform Target;

		public float RepathRate;

		private float timeSinceLastPath;

		private void Update()
		{
		}
	}
}
