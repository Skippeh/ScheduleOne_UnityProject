namespace ScheduleOne.Tools
{
	public class CountdownText : global::UnityEngine.MonoBehaviour
	{
		public global::TMPro.TextMeshProUGUI TimeLabel;

		[global::UnityEngine.Header("Date Setting")]
		public int Year;

		public int Month;

		public int Day;

		public int Hour;

		public int Minute;

		public int Second;

		private global::System.DateTime targetPDTDate;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateCountdown()
		{
		}

		private string FormatTime(global::System.TimeSpan timeSpan)
		{
			return null;
		}
	}
}
