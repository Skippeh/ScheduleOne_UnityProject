namespace ScheduleOne.Law
{
	[global::System.Serializable]
	public class SentryInstance
	{
		public global::ScheduleOne.Law.SentryLocation[] _potentialLocations;

		public int Members;

		[global::UnityEngine.Header("Timing")]
		public int StartTime;

		public int EndTime;

		[global::UnityEngine.Range(1f, 10f)]
		public int IntensityRequirement;

		public bool OnlyIfCurfewEnabled;

		private global::System.Collections.Generic.List<global::ScheduleOne.Police.PoliceOfficer> _activeOfficers;

		private global::ScheduleOne.Law.SentryLocation _activeLocation;

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

		private global::ScheduleOne.Law.SentryLocation GetRandomUnoccupiedLocation()
		{
			return null;
		}
	}
}
