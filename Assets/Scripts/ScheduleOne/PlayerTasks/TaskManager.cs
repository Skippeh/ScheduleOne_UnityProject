using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.PlayerTasks
{
	public class TaskManager : Singleton<TaskManager>
	{
		public Task currentTask;

		public AudioSourceController TaskCompleteSound;

		public Action<Task> OnTaskStarted;

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		private void Exit(ExitAction action)
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

		public void StartTask(Task task)
		{
		}
	}
}
