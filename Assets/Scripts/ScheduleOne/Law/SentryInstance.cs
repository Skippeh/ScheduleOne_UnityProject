namespace ScheduleOne.Law
{
	[global::System.Serializable]
	public class SentryInstance
	{
		public global::ScheduleOne.Law.SentryLocation Location;

		public int Members;

		[global::UnityEngine.Header("Timing")]
		public int StartTime;

		public int EndTime;

		[global::UnityEngine.Range(1f, 10f)]
		public int IntensityRequirement;

		public bool OnlyIfCurfewEnabled;

		private global::System.Collections.Generic.List<global::ScheduleOne.Police.PoliceOfficer> officers;

		public void Evaluate()
		{
		}

		public void StartEntry()
		{
		}

		private void MinPass()
		{
		}

		public void EndSentry()
		{
		}
	}
}
