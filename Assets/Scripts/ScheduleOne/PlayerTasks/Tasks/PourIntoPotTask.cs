namespace ScheduleOne.PlayerTasks.Tasks
{
	public class PourIntoPotTask : global::ScheduleOne.PlayerTasks.Task
	{
		protected global::ScheduleOne.ObjectScripts.Pot pot;

		protected global::ScheduleOne.ItemFramework.ItemInstance item;

		protected global::ScheduleOne.PlayerTasks.Pourable pourable;

		protected bool removeItemAfterInitialPour;

		public override string TaskName { get; protected set; }

		protected virtual bool UseCoverage { get; }

		protected virtual bool FailOnEmpty { get; }

		protected virtual global::ScheduleOne.ObjectScripts.Pot.ECameraPosition CameraPosition { get; }

		public PourIntoPotTask(global::ScheduleOne.ObjectScripts.Pot _pot, global::ScheduleOne.ItemFramework.ItemInstance _itemInstance, global::ScheduleOne.PlayerTasks.Pourable _pourablePrefab)
		{
		}

		public override void Update()
		{
		}

		public override void StopTask()
		{
		}

		private void OnInitialPour()
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
