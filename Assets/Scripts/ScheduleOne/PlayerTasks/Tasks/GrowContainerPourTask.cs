namespace ScheduleOne.PlayerTasks.Tasks
{
	public class GrowContainerPourTask : global::ScheduleOne.PlayerTasks.Task
	{
		protected global::ScheduleOne.Growing.GrowContainer growContainer;

		protected global::ScheduleOne.ItemFramework.ItemInstance item;

		protected global::ScheduleOne.PlayerTasks.Pourable pourable;

		protected bool removeItemAfterInitialPour;

		public override string TaskName { get; protected set; }

		protected virtual bool UseCoverage { get; }

		protected virtual bool FailOnEmpty { get; }

		protected virtual global::ScheduleOne.Growing.GrowContainerCameraHandler.ECameraPosition CameraPosition { get; }

		public GrowContainerPourTask(global::ScheduleOne.Growing.GrowContainer _growContainer, global::ScheduleOne.ItemFramework.ItemInstance _itemInstance, global::ScheduleOne.PlayerTasks.Pourable _pourablePrefab)
		{
		}

		public override void Update()
		{
		}

		public override void StopTask()
		{
		}

		protected virtual void OnInitialPour()
		{
		}

		protected void RemoveItem()
		{
		}

		protected virtual void FullyCovered()
		{
		}
	}
}
