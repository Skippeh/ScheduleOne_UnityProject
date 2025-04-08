namespace ScheduleOne.Doors
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class DoorSensor : global::UnityEngine.MonoBehaviour
	{
		public const float ActivationDistance = 30f;

		public global::ScheduleOne.Doors.EDoorSide DetectorSide;

		public global::ScheduleOne.Doors.DoorController Door;

		private global::System.Collections.Generic.List<global::UnityEngine.Collider> exclude;

		private global::UnityEngine.Collider collider;

		private void Awake()
		{
		}

		private void UpdateCollider()
		{
		}

		private void OnTriggerStay(global::UnityEngine.Collider other)
		{
		}
	}
}
