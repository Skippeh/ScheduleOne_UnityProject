namespace ScheduleOne.Tools
{
	public class RigidbodyEventBroadcaster : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Events.UnityEvent<global::UnityEngine.Collider> onTriggerEnter;

		private void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}
	}
}
