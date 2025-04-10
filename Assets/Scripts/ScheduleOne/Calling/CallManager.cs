namespace ScheduleOne.Calling
{
	public class CallManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Calling.CallManager>
	{
		public global::ScheduleOne.ScriptableObjects.PhoneCallData QueuedCallData { get; private set; }

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
