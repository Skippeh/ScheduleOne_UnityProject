namespace ScheduleOne.Doors
{
	public class PivotDoor : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Transform DoorTransform;

		public bool FlipSide;

		public float OpenInwardsAngle;

		public float OpenOutwardsAngle;

		public float SwingSpeed;

		private bool isUpdatingDoor;

		private float targetDoorAngle;

		protected virtual void Awake()
		{
		}

		public virtual void Opened(global::ScheduleOne.Doors.EDoorSide openSide)
		{
		}

		public virtual void Closed()
		{
		}

		private void UpdateDoor()
		{
		}
	}
}
