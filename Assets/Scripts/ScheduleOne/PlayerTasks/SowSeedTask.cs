using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.PlayerTasks
{
	public class SowSeedTask : Task
	{
		protected Pot pot;

		protected SeedDefinition definition;

		protected FunctionalSeed seed;

		private bool seedExitedVial;

		private bool seedReachedDestination;

		private bool successfullyPlanted;

		private float weedSeedStationaryTime;

		private bool capRemoved;

		public override string TaskName { get; protected set; }

		public SowSeedTask(Pot _pot, SeedDefinition def)
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
