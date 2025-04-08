namespace ScheduleOne.ObjectScripts
{
	public class FunctionalWateringCan : global::ScheduleOne.PlayerTasks.Pourable
	{
		public global::ScheduleOne.ObjectScripts.WateringCan.WateringCanVisuals Visuals;

		private global::ScheduleOne.ObjectScripts.WateringCan.WateringCanInstance itemInstance;

		public void Setup(global::ScheduleOne.ObjectScripts.WateringCan.WateringCanInstance instance)
		{
		}

		protected override void PourAmount(float amount)
		{
		}
	}
}
