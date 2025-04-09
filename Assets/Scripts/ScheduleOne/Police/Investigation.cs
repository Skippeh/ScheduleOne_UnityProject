using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Police
{
	public class Investigation
	{
		public float CurrentProgress { get; protected set; }

		public Player Target { get; protected set; }

		public Investigation(Player target)
		{
		}

		public void ChangeProgress(float progress)
		{
		}
	}
}
