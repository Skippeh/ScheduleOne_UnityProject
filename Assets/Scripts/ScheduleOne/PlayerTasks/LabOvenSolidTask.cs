using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;

namespace ScheduleOne.PlayerTasks
{
	public class LabOvenSolidTask : Task
	{
		public enum EStep
		{
			OpenDoor = 0,
			PlaceItems = 1,
			CloseDoor = 2,
			PressButton = 3
		}

		private ItemInstance ingredient;

		private int ingredientQuantity;

		private StationItem[] stationItems;

		private Draggable[] stationDraggables;

		public LabOven Oven { get; private set; }

		public EStep CurrentStep { get; protected set; }

		public LabOvenSolidTask(LabOven oven)
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

		public static string GetStepInstruction(EStep step)
		{
			return null;
		}
	}
}
