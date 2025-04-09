using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;

namespace ScheduleOne.PlayerTasks
{
	public class UseChemistryStationTask : Task
	{
		public const float STIR_TIME = 1.5f;

		public const float TEMPERATURE_TIME = 2f;

		private Beaker beaker;

		private StirringRod stirringRod;

		private List<StationItem> items;

		private List<IngredientPiece> ingredientPieces;

		private float stirProgress;

		private float timeInTemperatureRange;

		private ItemInstance[] RemovedIngredients;

		public ChemistryStation.EStep CurrentStep { get; private set; }

		public ChemistryStation Station { get; private set; }

		public StationRecipe Recipe { get; private set; }

		public static string GetStepDescription(ChemistryStation.EStep step)
		{
			return null;
		}

		public UseChemistryStationTask(ChemistryStation station, StationRecipe recipe)
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
