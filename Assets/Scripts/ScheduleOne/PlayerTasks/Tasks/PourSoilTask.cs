namespace ScheduleOne.PlayerTasks.Tasks
{
	public class PourSoilTask : global::ScheduleOne.PlayerTasks.Tasks.GrowContainerPourTask
	{
		private global::ScheduleOne.ItemFramework.SoilDefinition _soilDefinition;

		private global::ScheduleOne.ObjectScripts.Soil.PourableSoil _pourableSoil;

		private global::UnityEngine.Collider _hoveredTopCollider;

		private global::ScheduleOne.Growing.GrowContainer _growContainer;

		public PourSoilTask(global::ScheduleOne.Growing.GrowContainer growContainer, global::ScheduleOne.ItemFramework.ItemInstance itemInstance, global::ScheduleOne.PlayerTasks.Pourable pourablePrefab)
			: base(null, null, null)
		{
		}

		protected override void OnInitialPour()
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
