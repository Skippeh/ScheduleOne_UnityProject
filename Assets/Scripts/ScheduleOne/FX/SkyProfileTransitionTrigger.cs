namespace ScheduleOne.FX
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Collider))]
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class SkyProfileTransitionTrigger : global::UnityEngine.MonoBehaviour
	{
		public global::Funly.SkyStudio.SkyProfile TransitionToOnEnter;

		public global::Funly.SkyStudio.SkyProfile TransitionToOnExit;

		public float TransitionDuration;

		public void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}

		public void OnTriggerExit(global::UnityEngine.Collider other)
		{
		}
	}
}
