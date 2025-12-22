namespace ScheduleOne.PlayerTasks
{
	public class FillWaterContainer : global::ScheduleOne.PlayerTasks.Task
	{
		private global::ScheduleOne.Property.Tap _tap;

		private global::ScheduleOne.ItemFramework.WaterContainerInstance _waterContainerItem;

		private global::ScheduleOne.Tools.FillableWaterContainer _fillable;

		public new string TaskName { get; protected set; }

		public FillWaterContainer(global::ScheduleOne.Property.Tap tap, global::ScheduleOne.ItemFramework.WaterContainerInstance waterContainerItem)
		{
		}

		public override void StopTask()
		{
		}

		public override void Update()
		{
		}

		private void UpdateInstruction()
		{
		}

		private void UpdateFillSound()
		{
		}
	}
}
