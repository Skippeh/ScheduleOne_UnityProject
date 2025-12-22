namespace ScheduleOne.PlayerTasks.Tasks
{
	public class MistMushroomBedTask : global::ScheduleOne.PlayerTasks.Task
	{
		private const float TARGET_SPRAY_RADIUS = 0.15f;

		private const float TARGET_SPRAY_DISTANCE = 0.35f;

		private global::ScheduleOne.ObjectScripts.MushroomBed _mushroomBed;

		private global::ScheduleOne.PlayerTasks.Sprayable _sprayable;

		private global::UnityEngine.GameObject _sprayableObj;

		private global::ScheduleOne.ItemFramework.WaterContainerInstance _waterContainerInstance;

		public override string TaskName { get; protected set; }

		public MistMushroomBedTask(global::ScheduleOne.ObjectScripts.MushroomBed mushroomBed, global::ScheduleOne.ItemFramework.ItemInstance item, global::UnityEngine.GameObject sprayablePrefab)
		{
		}

		private void OnSuccessfulSpray()
		{
		}

		private void OnSpray()
		{
		}

		public override void StopTask()
		{
		}
	}
}
