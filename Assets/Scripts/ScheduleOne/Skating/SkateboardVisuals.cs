namespace ScheduleOne.Skating
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Skating.Skateboard))]
	public class SkateboardVisuals : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public float MaxBoardLean;

		public float BoardLeanRate;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform Board;

		private global::ScheduleOne.Skating.Skateboard skateboard;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
