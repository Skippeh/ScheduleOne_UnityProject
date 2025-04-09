using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;

namespace ScheduleOne.PlayerTasks.Tasks
{
	public class UseMixingStationTask : Task
	{
		public enum EStep
		{
			CombineIngredients = 0,
			StartMixing = 1
		}

		private List<StationItem> items;

		private List<StationItem> mixerItems;

		private List<IngredientPiece> ingredientPieces;

		private ItemInstance[] removedIngredients;

		private Beaker Jug;

		public MixingStation Station { get; private set; }

		public EStep CurrentStep { get; private set; }

		public static string GetStepDescription(EStep step)
		{
			return null;
		}

		public UseMixingStationTask(MixingStation station)
		{
		}

		private Beaker CreateJug()
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
