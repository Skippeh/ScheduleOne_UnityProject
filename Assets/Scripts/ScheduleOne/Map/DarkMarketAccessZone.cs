namespace ScheduleOne.Map
{
	public class DarkMarketAccessZone : global::ScheduleOne.Map.TimedAccessZone
	{
		protected override bool GetIsOpen()
		{
			return false;
		}
	}
}
