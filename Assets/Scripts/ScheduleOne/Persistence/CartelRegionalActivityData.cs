namespace ScheduleOne.Persistence
{
	[global::System.Serializable]
	public class CartelRegionalActivityData
	{
		public global::ScheduleOne.Map.EMapRegion Region;

		public int CurrentActivityIndex;

		public int HoursUntilNextActivity;

		public CartelRegionalActivityData(global::ScheduleOne.Map.EMapRegion region, int currentActivityIndex, int hoursUntilNextActivity)
		{
		}
	}
}
