namespace ScheduleOne.Tools
{
	public class DelayedUnityEvent : global::UnityEngine.MonoBehaviour
	{
		public float Delay;

		public global::UnityEngine.Events.UnityEvent onDelayStart;

		public global::UnityEngine.Events.UnityEvent onDelayedExecute;

		[global::ScheduleOne.Core.Button]
		public void Execute()
		{
		}
	}
}
