using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	[RequireComponent(typeof(Rigidbody))]
	public class CombatNPCDetector : MonoBehaviour
	{
		public bool DetectOnlyInCombat;

		public UnityEvent onDetected;

		public float ContactTimeForDetection;

		private float contactTime;

		private float timeSinceLastContact;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}
	}
}
