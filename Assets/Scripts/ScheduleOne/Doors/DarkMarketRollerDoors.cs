namespace ScheduleOne.Doors
{
	public class DarkMarketRollerDoors : SensorRollerDoors
	{
		protected override bool CanOpen()
		{
			return false;
		}
	}
}
