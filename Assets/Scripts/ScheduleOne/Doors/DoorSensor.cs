namespace ScheduleOne.Doors
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class DoorSensor : global::UnityEngine.MonoBehaviour
	{
		public const float ActivationDistance = 30f;

		public global::ScheduleOne.Doors.EDoorSide DetectorSide;

		public global::ScheduleOne.Doors.DoorController Door;

		private global::UnityEngine.Collider collider;

		private global::System.Collections.Generic.List<global::UnityEngine.Collider> exclude;

		private global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> npcsInContact;

		private global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.Player> playersInContact;

		private float maxContactDistanceSqr;

		private void Awake()
		{
		}

		private void UpdateCollider()
		{
		}

		private void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}

		private void OnTriggerExit(global::UnityEngine.Collider other)
		{
		}

		private void FixedUpdate()
		{
		}

		private void RemoveInvalidContacts()
		{
		}
	}
}
