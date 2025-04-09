namespace ScheduleOne.Map
{
	public class DarkMarketAccessZone : TimedAccessZone
	{
		protected override bool GetIsOpen()
		{
			return false;
		}
	}
}
