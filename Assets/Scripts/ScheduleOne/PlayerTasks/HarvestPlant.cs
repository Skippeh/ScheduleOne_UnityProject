namespace ScheduleOne.PlayerTasks
{
	public class HarvestPlant : global::ScheduleOne.PlayerTasks.Task
	{
		protected global::ScheduleOne.ObjectScripts.Pot pot;

		private int HarvestCount;

		private int HarvestTotal;

		private float rotation;

		private static bool hintShown;

		private static bool CanDrag;

		private global::ScheduleOne.Audio.AudioSourceController SoundLoop;

		public override string TaskName { get; protected set; }

		public HarvestPlant(global::ScheduleOne.ObjectScripts.Pot _pot, bool canDrag, global::ScheduleOne.Audio.AudioSourceController soundLoopPrefab)
		{
		}

		private void UpdateInstructionText()
		{
		}

		public override void StopTask()
		{
		}

		protected override void UpdateCursor()
		{
		}

		public override void Update()
		{
		}

		private global::ScheduleOne.Growing.PlantHarvestable GetHoveredHarvestable()
		{
			return null;
		}
	}
}
