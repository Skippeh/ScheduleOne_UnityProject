namespace ScheduleOne.PlayerTasks
{
	public class InocculateGrainBagTask : global::ScheduleOne.PlayerTasks.Task
	{
		public enum EStage
		{
			RemoveCap = 0,
			InsertSyringe = 1,
			PushPlunger = 2
		}

		private global::ScheduleOne.StationFramework.MushroomSpawnStation _station;

		private global::ScheduleOne.StationFramework.MushroomSpawnStationItem _spawn;

		private global::ScheduleOne.StationFramework.SporeSyringeStationItem _syringe;

		private global::ScheduleOne.PlayerTasks.InocculateGrainBagTask.EStage _currentStage;

		private global::ScheduleOne.ItemFramework.ItemInstance _grainBagInstance;

		private global::ScheduleOne.ItemFramework.ItemInstance _syringeInstance;

		private global::ScheduleOne.ItemFramework.ShroomSpawnDefinition _spawnDefinition;

		public override string TaskName { get; protected set; }

		public InocculateGrainBagTask(global::ScheduleOne.StationFramework.MushroomSpawnStation station)
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

		private string GetInstructionForStage(global::ScheduleOne.PlayerTasks.InocculateGrainBagTask.EStage stage)
		{
			return null;
		}

		private void OnSyringeCapRemoved()
		{
		}

		private void OnSyringeInserted()
		{
		}

		private void OnPlungerPushed(float amount)
		{
		}
	}
}
