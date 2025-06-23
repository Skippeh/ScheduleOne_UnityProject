namespace ScheduleOne.Polling
{
	[global::System.Serializable]
	public class PollResponse
	{
		public global::ScheduleOne.Polling.PollData[] polls;

		public int active;

		public int confirmed;

		public global::ScheduleOne.Polling.PollData GetActive()
		{
			return null;
		}

		public global::ScheduleOne.Polling.PollData GetConfirmed()
		{
			return null;
		}
	}
}
