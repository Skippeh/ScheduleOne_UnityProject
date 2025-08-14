namespace ScheduleOne.Tools
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class CombatNPCDetector : global::UnityEngine.MonoBehaviour
	{
		public bool DetectOnlyInCombat;

		public global::UnityEngine.Events.UnityEvent onDetected;

		public float ContactTimeForDetection;

		private bool inContact;

		private global::ScheduleOne.NPCs.NPC npcInContact;

		private float contactTime;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}

		private void OnTriggerExit(global::UnityEngine.Collider other)
		{
		}
	}
}
