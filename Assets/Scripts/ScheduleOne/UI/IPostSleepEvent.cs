namespace ScheduleOne.UI
{
	public interface IPostSleepEvent
	{
		bool IsRunning { get; }

		int Order { get; }

		void StartEvent();
	}
}
