namespace ScheduleOne.Economy
{
	public struct DealWindowInfo
	{
		public const int WINDOW_DURATION_MINS = 360;

		public const int WINDOW_COUNT = 4;

		public int StartTime;

		public int EndTime;

		public static readonly global::ScheduleOne.Economy.DealWindowInfo Morning;

		public static readonly global::ScheduleOne.Economy.DealWindowInfo Afternoon;

		public static readonly global::ScheduleOne.Economy.DealWindowInfo Night;

		public static readonly global::ScheduleOne.Economy.DealWindowInfo LateNight;

		public DealWindowInfo(int startTime, int endTime)
		{
			StartTime = 0;
			EndTime = 0;
		}

		public static global::ScheduleOne.Economy.DealWindowInfo GetWindowInfo(global::ScheduleOne.Economy.EDealWindow window)
		{
			return default(global::ScheduleOne.Economy.DealWindowInfo);
		}

		public static global::ScheduleOne.Economy.EDealWindow GetWindow(int time)
		{
			return default(global::ScheduleOne.Economy.EDealWindow);
		}
	}
}
