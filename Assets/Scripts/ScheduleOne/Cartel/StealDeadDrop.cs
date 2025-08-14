namespace ScheduleOne.Cartel
{
	public class StealDeadDrop : global::ScheduleOne.Cartel.CartelActivity
	{
		public const int MIN_TIME_SINCE_CONTENTS_CHANGED = 360;

		public global::ScheduleOne.ItemFramework.ItemDefinition[] ItemsToLeave;

		public override bool IsRegionValidForActivity(global::ScheduleOne.Map.EMapRegion region)
		{
			return false;
		}

		public override void Activate(global::ScheduleOne.Map.EMapRegion region)
		{
		}

		private static global::ScheduleOne.Economy.DeadDrop GetRandomDropToStealFrom(global::ScheduleOne.Map.EMapRegion region)
		{
			return null;
		}
	}
}
