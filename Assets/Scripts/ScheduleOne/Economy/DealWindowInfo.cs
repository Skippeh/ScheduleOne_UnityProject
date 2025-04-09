namespace ScheduleOne.Economy
{
	public struct DealWindowInfo
	{
		public const int WINDOW_DURATION_MINS = 360;

		public const int WINDOW_COUNT = 4;

		public int StartTime;

		public int EndTime;

		public static readonly DealWindowInfo Morning;

		public static readonly DealWindowInfo Afternoon;

		public static readonly DealWindowInfo Night;

		public static readonly DealWindowInfo LateNight;

		public DealWindowInfo(int startTime, int endTime)
		{
			this.StartTime = startTime;
			this.EndTime = endTime;
		}

		public static DealWindowInfo GetWindowInfo(EDealWindow window)
		{
			return default(DealWindowInfo);
		}

		public static EDealWindow GetWindow(int time)
		{
			return default(EDealWindow);
		}
	}
}
