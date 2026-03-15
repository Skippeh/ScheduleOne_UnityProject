namespace ScheduleOne.Map.Infrastructure
{
	public class StreetLight : global::UnityEngine.MonoBehaviour
	{
		private static global::UnityEngine.Vector3 PowerOrigin;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Misc.ToggleableLight _light;

		[global::UnityEngine.Header("Timing")]
		public int StartTime;

		public int EndTime;

		private int _startTimeOffset;

		protected virtual void Awake()
		{
		}

		private void Start()
		{
		}

		private void UpdateState()
		{
		}

		private void SetState(bool on)
		{
		}
	}
}
