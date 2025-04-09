using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.PlayerTasks.Tasks
{
	public class PourWaterTask : PourOntoTargetTask
	{
		public const float NORMALIZED_FILL_PER_TARGET = 0.2f;

		public static bool hintShown;

		protected override bool UseCoverage => false;

		protected override bool FailOnEmpty => false;

		protected override Pot.ECameraPosition CameraPosition => default(Pot.ECameraPosition);

		public PourWaterTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab)
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
