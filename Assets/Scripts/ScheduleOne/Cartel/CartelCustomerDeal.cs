namespace ScheduleOne.Cartel
{
	public class CartelCustomerDeal : global::ScheduleOne.Cartel.CartelActivity
	{
		public const int TIMEOUT_MINUTES = 720;

		private global::ScheduleOne.Cartel.CartelDealer dealer;

		public override bool IsRegionValidForActivity(global::ScheduleOne.Map.EMapRegion region)
		{
			return false;
		}

		public override void Activate(global::ScheduleOne.Map.EMapRegion region)
		{
		}

		protected override void MinPassed()
		{
		}

		protected override void Deactivate()
		{
		}

		private void DealerUnconscious()
		{
		}
	}
}
