namespace ScheduleOne.PlayerTasks
{
	public class UseChemistryStationTask : global::ScheduleOne.PlayerTasks.Task
	{
		public const float STIR_TIME = 1.5f;

		public const float TEMPERATURE_TIME = 2f;

		private global::ScheduleOne.ObjectScripts.Beaker beaker;

		private global::ScheduleOne.ObjectScripts.StirringRod stirringRod;

		private global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.StationItem> items;

		private global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.IngredientPiece> ingredientPieces;

		private float stirProgress;

		private float timeInTemperatureRange;

		private global::ScheduleOne.ItemFramework.ItemInstance[] RemovedIngredients;

		public global::ScheduleOne.ObjectScripts.ChemistryStation.EStep CurrentStep { get; private set; }

		public global::ScheduleOne.ObjectScripts.ChemistryStation Station { get; private set; }

		public global::ScheduleOne.StationFramework.StationRecipe Recipe { get; private set; }

		public static string GetStepDescription(global::ScheduleOne.ObjectScripts.ChemistryStation.EStep step)
		{
			return null;
		}

		public UseChemistryStationTask(global::ScheduleOne.ObjectScripts.ChemistryStation station, global::ScheduleOne.StationFramework.StationRecipe recipe)
		{
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

		private void ProgressStep()
		{
		}

		private void CheckStep_CombineIngredients()
		{
		}

		private void CheckStep_StirMixture()
		{
		}

		private void CheckStep_LowerBoilingFlask()
		{
		}

		private void CheckStep_PourIntoBoilingFlask()
		{
		}

		private void CheckStep_RaiseBoilingFlask()
		{
		}

		private void CheckStep_StartHeat()
		{
		}

		public override void Success()
		{
		}

		public override void StopTask()
		{
		}
	}
}
