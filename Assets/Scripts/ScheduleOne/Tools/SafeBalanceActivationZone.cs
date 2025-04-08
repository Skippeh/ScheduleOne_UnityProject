namespace ScheduleOne.Tools
{
	public class SafeBalanceActivationZone : global::UnityEngine.MonoBehaviour
	{
		public const float ActivationDistance = 30f;

		public global::ScheduleOne.Storage.Safe Safe;

		private global::System.Collections.Generic.List<global::UnityEngine.Collider> exclude;

		private global::UnityEngine.Collider[] colliders;

		private bool active;

		private void Awake()
		{
		}

		private void UpdateCollider()
		{
		}

		private void Activate()
		{
		}

		private void OnTriggerStay(global::UnityEngine.Collider other)
		{
		}
	}
}
