namespace ScheduleOne.PlayerTasks
{
	public class TaskManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.PlayerTasks.TaskManager>
	{
		public global::ScheduleOne.PlayerTasks.Task currentTask;

		public global::ScheduleOne.Audio.AudioSourceController TaskCompleteSound;

		public global::System.Action<global::ScheduleOne.PlayerTasks.Task> OnTaskStarted;

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		public void PlayTaskCompleteSound()
		{
		}

		public void StartTask(global::ScheduleOne.PlayerTasks.Task task)
		{
		}
	}
}
