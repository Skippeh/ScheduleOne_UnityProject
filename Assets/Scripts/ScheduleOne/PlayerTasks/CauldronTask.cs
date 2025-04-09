using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;

namespace ScheduleOne.PlayerTasks
{
	public class CauldronTask : Task
	{
		public enum EStep
		{
			CombineIngredients = 0,
			StartMixing = 1
		}

		private StationItem[] CocaLeaves;

		private StationItem Gasoline;

		private Draggable Tub;

		public Cauldron Cauldron { get; private set; }

		public EStep CurrentStep { get; private set; }

		public static string GetStepDescription(EStep step)
		{
			return null;
		}

		public CauldronTask(Cauldron caudron)
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
