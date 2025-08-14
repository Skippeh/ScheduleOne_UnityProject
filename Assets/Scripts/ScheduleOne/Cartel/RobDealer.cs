namespace ScheduleOne.Cartel
{
	public class RobDealer : global::ScheduleOne.Cartel.CartelActivity
	{
		public override bool IsRegionValidForActivity(global::ScheduleOne.Map.EMapRegion region)
		{
			return false;
		}

		private global::ScheduleOne.Economy.Dealer GetDealerToRob(global::ScheduleOne.Map.EMapRegion region)
		{
			return null;
		}

		public override void Activate(global::ScheduleOne.Map.EMapRegion region)
		{
		}
	}
}
