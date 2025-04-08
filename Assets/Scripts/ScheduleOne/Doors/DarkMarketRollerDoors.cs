namespace ScheduleOne.Doors
{
	public class DarkMarketRollerDoors : global::ScheduleOne.Doors.SensorRollerDoors
	{
		protected override bool CanOpen()
		{
			return false;
		}
	}
}
