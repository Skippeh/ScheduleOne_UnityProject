namespace ScheduleOne.GameTime
{
	public class TimedCallback
	{
		private int _remainingMinutes;

		private global::System.Action _callback;

		private int _initialRemainingMinutes;

		public TimedCallback(global::System.Action callback, int durationMinutes, bool tickAtEndOfDay = true, bool tickOnTimeSkip = true)
		{
		}

		public void Cancel()
		{
		}

		public void Reset()
		{
		}

		private void OnTimeSkip(int skippedMinutes)
		{
		}

		private void Tick()
		{
		}

		private void Execute()
		{
		}

		private void Cleanup()
		{
		}
	}
}
