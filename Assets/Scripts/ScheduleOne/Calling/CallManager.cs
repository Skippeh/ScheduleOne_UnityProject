namespace ScheduleOne.Calling
{
	public class CallManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Calling.CallManager>
	{
		private global::ScheduleOne.ScriptableObjects.PhoneCallData QueuedCallData { get; set; }

		public event global::System.Action<global::ScheduleOne.ScriptableObjects.PhoneCallData> OnCallQueued
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void QueueCall(global::ScheduleOne.ScriptableObjects.PhoneCallData data)
		{
		}

		public void ClearQueuedCall()
		{
		}

		private void CallCompleted(global::ScheduleOne.ScriptableObjects.PhoneCallData call)
		{
		}
	}
}
