namespace ScheduleOne.Police
{
	public class Investigation
	{
		public float CurrentProgress { get; protected set; }

		public global::ScheduleOne.PlayerScripts.Player Target { get; protected set; }

		public Investigation(global::ScheduleOne.PlayerScripts.Player target)
		{
		}

		public void ChangeProgress(float progress)
		{
		}
	}
}
