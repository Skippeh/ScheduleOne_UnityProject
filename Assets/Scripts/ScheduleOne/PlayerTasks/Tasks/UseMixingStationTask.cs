namespace ScheduleOne.PlayerTasks.Tasks
{
	public class UseMixingStationTask : global::ScheduleOne.PlayerTasks.Task
	{
		public enum EStep
		{
			CombineIngredients = 0,
			StartMixing = 1
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.StationItem> items;

		private global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.StationItem> mixerItems;

		private global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.IngredientPiece> ingredientPieces;

		private global::ScheduleOne.ItemFramework.ItemInstance[] removedIngredients;

		private global::ScheduleOne.ObjectScripts.Beaker Jug;

		public global::ScheduleOne.ObjectScripts.MixingStation Station { get; private set; }

		public global::ScheduleOne.PlayerTasks.Tasks.UseMixingStationTask.EStep CurrentStep { get; private set; }

		public static string GetStepDescription(global::ScheduleOne.PlayerTasks.Tasks.UseMixingStationTask.EStep step)
		{
			return null;
		}

		public UseMixingStationTask(global::ScheduleOne.ObjectScripts.MixingStation station)
		{
		}

		private global::ScheduleOne.ObjectScripts.Beaker CreateJug()
		{
			return null;
		}

		public override void Update()
		{
		}

		private void UpdateInstruction()
		{
		}

		private void CheckProgress()
		{
		}

		private void CheckStep_CombineIngredients()
		{
		}

		private int GetCombinedIngredients()
		{
			return 0;
		}

		private void ProgressStep()
		{
		}

		private void StartButtonPressed()
		{
		}

		public override void Success()
		{
		}

		private void CreateTrash()
		{
		}

		public override void StopTask()
		{
		}
	}
}
