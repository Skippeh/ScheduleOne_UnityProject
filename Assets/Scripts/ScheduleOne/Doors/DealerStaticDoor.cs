using ScheduleOne.Economy;

namespace ScheduleOne.Doors
{
	public class DealerStaticDoor : StaticDoor
	{
		public Dealer Dealer;

		protected override bool IsKnockValid(out string message)
		{
			message = null;
			return false;
		}
	}
}
