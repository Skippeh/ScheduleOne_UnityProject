namespace ScheduleOne.PlayerTasks.Tasks
{
	public class PourOntoTargetTask : global::ScheduleOne.PlayerTasks.Tasks.GrowContainerPourTask
	{
		public float SUCCESS_THRESHOLD;

		public float SUCCESS_TIME;

		private float timeOverTarget;

		public PourOntoTargetTask(global::ScheduleOne.Growing.GrowContainer _growContainer, global::ScheduleOne.ItemFramework.ItemInstance _itemInstance, global::ScheduleOne.PlayerTasks.Pourable _pourablePrefab)
			: base(null, null, null)
		{
		}

		public override void Update()
		{
		}

		public override void StopTask()
		{
		}

		public virtual void TargetReached()
		{
		}
	}
}
