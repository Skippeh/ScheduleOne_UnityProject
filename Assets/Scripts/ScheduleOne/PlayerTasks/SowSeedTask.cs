namespace ScheduleOne.PlayerTasks
{
	public class SowSeedTask : global::ScheduleOne.PlayerTasks.Task
	{
		protected global::ScheduleOne.ObjectScripts.Pot pot;

		protected global::ScheduleOne.Growing.SeedDefinition definition;

		protected global::ScheduleOne.Growing.FunctionalSeed seed;

		private bool seedExitedVial;

		private bool seedReachedDestination;

		private bool successfullyPlanted;

		private float weedSeedStationaryTime;

		private bool capRemoved;

		public override string TaskName { get; protected set; }

		public SowSeedTask(global::ScheduleOne.ObjectScripts.Pot _pot, global::ScheduleOne.Growing.SeedDefinition def)
		{
		}

		public override void Update()
		{
		}

		public override void Success()
		{
		}

		public override void StopTask()
		{
		}

		private void OnSeedExitVial()
		{
		}

		private void OnSeedReachedDestination()
		{
		}
	}
}
