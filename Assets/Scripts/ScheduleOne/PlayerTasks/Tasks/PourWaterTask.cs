namespace ScheduleOne.PlayerTasks.Tasks
{
	public class PourWaterTask : global::ScheduleOne.PlayerTasks.Tasks.PourOntoTargetTask
	{
		public const float NORMALIZED_FILL_PER_TARGET = 0.2f;

		public static bool hintShown;

		protected override bool UseCoverage => false;

		protected override bool FailOnEmpty => false;

		protected override global::ScheduleOne.Growing.GrowContainerCameraHandler.ECameraPosition CameraPosition => default(global::ScheduleOne.Growing.GrowContainerCameraHandler.ECameraPosition);

		public PourWaterTask(global::ScheduleOne.Growing.GrowContainer _growContainer, global::ScheduleOne.ItemFramework.ItemInstance _itemInstance, global::ScheduleOne.PlayerTasks.Pourable _pourablePrefab)
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
