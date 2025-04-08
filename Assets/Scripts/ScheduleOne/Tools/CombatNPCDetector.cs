namespace ScheduleOne.Tools
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class CombatNPCDetector : global::UnityEngine.MonoBehaviour
	{
		public bool DetectOnlyInCombat;

		public global::UnityEngine.Events.UnityEvent onDetected;

		public float ContactTimeForDetection;

		private float contactTime;

		private float timeSinceLastContact;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnTriggerStay(global::UnityEngine.Collider other)
		{
		}
	}
}
