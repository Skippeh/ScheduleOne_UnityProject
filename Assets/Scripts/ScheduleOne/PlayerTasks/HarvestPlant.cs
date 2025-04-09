using ScheduleOne.Audio;
using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.PlayerTasks
{
	public class HarvestPlant : Task
	{
		protected Pot pot;

		private int HarvestCount;

		private int HarvestTotal;

		private float rotation;

		private static bool hintShown;

		private static bool CanDrag;

		private AudioSourceController SoundLoop;

		public override string TaskName { get; protected set; }

		public HarvestPlant(Pot _pot, bool canDrag, AudioSourceController soundLoopPrefab)
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

		private PlantHarvestable GetHoveredHarvestable()
		{
			return null;
		}
	}
}
