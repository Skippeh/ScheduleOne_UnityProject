namespace ScheduleOne.Tools
{
	public class ImpactDetector : global::UnityEngine.MonoBehaviour
	{
		public bool DestroyScriptOnImpact;

		public global::UnityEngine.Events.UnityEvent onImpact;

		private void OnCollisionEnter(global::UnityEngine.Collision collision)
		{
		}
	}
}
