namespace ScheduleOne.Skating
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Skating.Skateboard))]
	public class SkateboardEffects : global::UnityEngine.MonoBehaviour
	{
		private global::ScheduleOne.Skating.Skateboard skateboard;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.TrailRenderer[] Trails;

		private float trailsOpacity;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
