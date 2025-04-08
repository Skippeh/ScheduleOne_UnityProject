namespace ScheduleOne.Lighting
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Misc.ToggleableLight))]
	public class LightTimer : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Timing")]
		public int StartTime;

		public int EndTime;

		public int StartTimeOffset;

		private global::ScheduleOne.Misc.ToggleableLight toggleableLight;

		protected virtual void Awake()
		{
		}

		private void Start()
		{
		}

		protected virtual void UpdateState()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void SetState(bool on)
		{
		}
	}
}
