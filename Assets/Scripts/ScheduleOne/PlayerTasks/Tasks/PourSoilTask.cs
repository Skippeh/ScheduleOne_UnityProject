namespace ScheduleOne.PlayerTasks.Tasks
{
	public class PourSoilTask : global::ScheduleOne.PlayerTasks.Tasks.PourIntoPotTask
	{
		private global::ScheduleOne.ObjectScripts.Soil.PourableSoil soil;

		private global::UnityEngine.Collider HoveredTopCollider;

		public PourSoilTask(global::ScheduleOne.ObjectScripts.Pot _pot, global::ScheduleOne.ItemFramework.ItemInstance _itemInstance, global::ScheduleOne.PlayerTasks.Pourable _pourablePrefab)
			: base(null, null, null)
		{
		}

		public override void Update()
		{
		}

		public override void StopTask()
		{
		}

		protected override void UpdateCursor()
		{
		}

		private void UpdateHover()
		{
		}

		private global::UnityEngine.Collider GetHoveredTopCollider()
		{
			return null;
		}
	}
}
