namespace ScheduleOne.Doors
{
	public class DealerStaticDoor : global::ScheduleOne.Doors.StaticDoor
	{
		public global::ScheduleOne.Economy.Dealer Dealer;

		protected override bool IsKnockValid(out string message)
		{
			message = null;
			return false;
		}
	}
}
