using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class TaskManagerUI : Singleton<TaskManagerUI>
	{
		private bool textShown;

		public GenericUIScreen inputPromptUI;

		public Canvas canvas;

		public RectTransform multiGrabIndicator;

		public GenericUIScreen PackagingStationMK2TutorialDone;

		protected virtual void Update()
		{
		}

		protected override void Start()
		{
		}

		protected virtual void UpdateInstructionLabel()
		{
		}

		private void TaskStarted(Task task)
		{
		}
	}
}
