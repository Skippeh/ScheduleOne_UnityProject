namespace ScheduleOne.PlayerTasks
{
	public class LabOvenSolidTask : global::ScheduleOne.PlayerTasks.Task
	{
		public enum EStep
		{
			OpenDoor = 0,
			PlaceItems = 1,
			CloseDoor = 2,
			PressButton = 3
		}

		private global::ScheduleOne.ItemFramework.ItemInstance ingredient;

		private int ingredientQuantity;

		private global::ScheduleOne.StationFramework.StationItem[] stationItems;

		private global::ScheduleOne.PlayerTasks.Draggable[] stationDraggables;

		public global::ScheduleOne.ObjectScripts.LabOven Oven { get; private set; }

		public global::ScheduleOne.PlayerTasks.LabOvenSolidTask.EStep CurrentStep { get; protected set; }

		public LabOvenSolidTask(global::ScheduleOne.ObjectScripts.LabOven oven)
		{
		}

		public override void Update()
		{
		}

		public override void Success()
		{
		}

		public override void StopTask()
		{
		}

		private void CheckProgress()
		{
		}

		private void ProgressStep()
		{
		}

		private void CheckStep_OpenDoor()
		{
		}

		private void CheckStep_PlaceItems()
		{
		}

		private void CheckStep_CloseDoor()
		{
		}

		private void CheckStep_PressButton()
		{
		}

		public static string GetStepInstruction(global::ScheduleOne.PlayerTasks.LabOvenSolidTask.EStep step)
		{
			return null;
		}
	}
}
