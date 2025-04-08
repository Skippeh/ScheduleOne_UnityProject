namespace ScheduleOne.UI
{
	public class TaskManagerUI : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.TaskManagerUI>
	{
		private bool textShown;

		public global::ScheduleOne.UI.GenericUIScreen inputPromptUI;

		public global::UnityEngine.Canvas canvas;

		public global::UnityEngine.RectTransform multiGrabIndicator;

		public global::ScheduleOne.UI.GenericUIScreen PackagingStationMK2TutorialDone;

		protected virtual void Update()
		{
		}

		protected override void Start()
		{
		}

		protected virtual void UpdateInstructionLabel()
		{
		}

		private void TaskStarted(global::ScheduleOne.PlayerTasks.Task task)
		{
		}
	}
}
