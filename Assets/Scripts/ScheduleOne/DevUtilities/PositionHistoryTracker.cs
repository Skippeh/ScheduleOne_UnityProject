namespace ScheduleOne.DevUtilities
{
	public class PositionHistoryTracker : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Tooltip("Frequency (in seconds) to record the position.")]
		public float recordingFrequency;

		[global::UnityEngine.Tooltip("Duration (in seconds) to store the position history.")]
		public float historyDuration;

		public global::System.Collections.Generic.List<global::UnityEngine.Vector3> positionHistory;

		private float lastRecordTime;

		public float RecordedTime => 0f;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void RecordPosition()
		{
		}

		public global::UnityEngine.Vector3 GetPositionXSecondsAgo(float secondsAgo)
		{
			return default(global::UnityEngine.Vector3);
		}

		public void ClearHistory()
		{
		}
	}
}
