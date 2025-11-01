namespace ScheduleOne.DevUtilities
{
	public class StaggeredCallbackUtility : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.DevUtilities.StaggeredCallbackUtility>
	{
		public void InvokeStaggered(int totalCalls, float totalTime, global::System.Action<int> callback, global::System.Action onComplete = null)
		{
		}

		public void InvokeStaggered(int totalCalls, int callsPerSecond, global::System.Action<int> callback, global::System.Action onComplete = null)
		{
		}
	}
}
