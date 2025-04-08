namespace ScheduleOne.PlayerTasks
{
	public class CauldronTask : global::ScheduleOne.PlayerTasks.Task
	{
		public enum EStep
		{
			CombineIngredients = 0,
			StartMixing = 1
		}

		private global::ScheduleOne.StationFramework.StationItem[] CocaLeaves;

		private global::ScheduleOne.StationFramework.StationItem Gasoline;

		private global::ScheduleOne.PlayerTasks.Draggable Tub;

		public global::ScheduleOne.ObjectScripts.Cauldron Cauldron { get; private set; }

		public global::ScheduleOne.PlayerTasks.CauldronTask.EStep CurrentStep { get; private set; }

		public static string GetStepDescription(global::ScheduleOne.PlayerTasks.CauldronTask.EStep step)
		{
			return null;
		}

		public CauldronTask(global::ScheduleOne.ObjectScripts.Cauldron caudron)
		{
		}

		public override void Success()
		{
		}

		public override void StopTask()
		{
		}

		public override void Update()
		{
		}

		private void CheckProgress()
		{
		}

		private void CheckStep_CombineIngredients()
		{
		}

		private void StartMixing()
		{
		}

		private void UpdateInstruction()
		{
		}

		private void StartButtonPressed()
		{
		}
	}
}
