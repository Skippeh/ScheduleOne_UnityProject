namespace ScheduleOne.Polling
{
	[global::System.Serializable]
	public class PollData
	{
		public int pollId;

		public string question;

		public string[] answers;

		public int winnerIndex;

		public string confirmationMessage;
	}
}
