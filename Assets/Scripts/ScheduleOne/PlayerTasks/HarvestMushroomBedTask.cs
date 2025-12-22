namespace ScheduleOne.PlayerTasks
{
	public class HarvestMushroomBedTask : global::ScheduleOne.PlayerTasks.Task
	{
		private global::ScheduleOne.Audio.AudioSourceController _soundLoop;

		private global::ScheduleOne.ObjectScripts.MushroomBed _mushroomBed;

		protected bool _canDrag;

		private int _harvestCount;

		private int _harvestTotal;

		public HarvestMushroomBedTask(global::ScheduleOne.ObjectScripts.MushroomBed mushroomBed, bool canDrag, global::ScheduleOne.Audio.AudioSourceController soundLoopPrefab)
		{
		}

		public override void StopTask()
		{
		}

		public override void Update()
		{
		}

		private void UpdateInstructionText()
		{
		}

		protected override void UpdateCursor()
		{
		}

		private global::ScheduleOne.Growing.GrowingMushroom GetHoveredHarvestable()
		{
			return null;
		}
	}
}
