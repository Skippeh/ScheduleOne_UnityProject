using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.PlayerTasks.Tasks
{
	public class PourIntoPotTask : Task
	{
		protected Pot pot;

		protected ItemInstance item;

		protected Pourable pourable;

		protected bool removeItemAfterInitialPour;

		public override string TaskName { get; protected set; }

		protected virtual bool UseCoverage { get; }

		protected virtual bool FailOnEmpty { get; }

		protected virtual Pot.ECameraPosition CameraPosition { get; }

		public PourIntoPotTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab)
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
