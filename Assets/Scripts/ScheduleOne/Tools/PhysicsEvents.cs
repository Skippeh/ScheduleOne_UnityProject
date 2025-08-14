namespace ScheduleOne.Tools
{
	public class PhysicsEvents : global::UnityEngine.MonoBehaviour
	{
		public bool DEBUG;

		public global::UnityEngine.Events.UnityEvent<global::UnityEngine.Collider> OnTriggerEnterEvent;

		public global::UnityEngine.Events.UnityEvent<global::UnityEngine.Collider> OnTriggerExitEvent;

		public global::UnityEngine.Events.UnityEvent<global::UnityEngine.Collision> OnCollisionEnterEvent;

		public global::UnityEngine.Events.UnityEvent<global::UnityEngine.Collision> OnCollisionExitEvent;

		public void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}

		public void OnTriggerExit(global::UnityEngine.Collider other)
		{
		}

		public void OnCollisionEnter(global::UnityEngine.Collision collision)
		{
		}

		public void OnCollisionExit(global::UnityEngine.Collision collision)
		{
		}

		private static string GetHierarchyString(global::UnityEngine.Transform transform)
		{
			return null;
		}
	}
}
