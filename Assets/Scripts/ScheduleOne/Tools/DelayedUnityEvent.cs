namespace ScheduleOne.Tools
{
	public class DelayedUnityEvent : global::UnityEngine.MonoBehaviour
	{
		public float Delay;

		public global::UnityEngine.Events.UnityEvent onDelayStart;

		public global::UnityEngine.Events.UnityEvent onDelayedExecute;

		[global::EasyButtons.Button]
		public void Execute()
		{
		}
	}
}
