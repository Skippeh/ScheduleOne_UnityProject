namespace ScheduleOne.PlayerTasks.Tasks
{
	public class PourWaterTask : global::ScheduleOne.PlayerTasks.Tasks.PourOntoTargetTask
	{
		public const float NORMALIZED_FILL_PER_TARGET = 0.2f;

		public static bool hintShown;

		protected override bool UseCoverage => false;

		protected override bool FailOnEmpty => false;

		protected override global::ScheduleOne.ObjectScripts.Pot.ECameraPosition CameraPosition => default(global::ScheduleOne.ObjectScripts.Pot.ECameraPosition);

		public PourWaterTask(global::ScheduleOne.ObjectScripts.Pot _pot, global::ScheduleOne.ItemFramework.ItemInstance _itemInstance, global::ScheduleOne.PlayerTasks.Pourable _pourablePrefab)
			: base(null, null, null)
		{
		}

		public override void StopTask()
		{
		}

		public override void TargetReached()
		{
		}
	}
}
