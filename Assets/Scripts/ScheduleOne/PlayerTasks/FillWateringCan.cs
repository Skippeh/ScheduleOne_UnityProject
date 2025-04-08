namespace ScheduleOne.PlayerTasks
{
	public class FillWateringCan : global::ScheduleOne.PlayerTasks.Task
	{
		protected global::ScheduleOne.Property.Utilities.Water.Tap tap;

		protected global::ScheduleOne.ObjectScripts.WateringCan.WateringCanInstance instance;

		protected global::ScheduleOne.ObjectScripts.WateringCan.WateringCanVisuals visuals;

		private bool audioPlayed;

		public new string TaskName { get; protected set; }

		public FillWateringCan(global::ScheduleOne.Property.Utilities.Water.Tap _tap, global::ScheduleOne.ObjectScripts.WateringCan.WateringCanInstance _instance)
		{
		}

		public override void Update()
		{
		}

		public override void StopTask()
		{
		}

		private void HandleClickStart(global::UnityEngine.RaycastHit hit)
		{
		}

		private void HandleClickEnd()
		{
		}
	}
}
