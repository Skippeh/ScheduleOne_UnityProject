namespace ScheduleOne.Doors
{
	public class SlidingDoor : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Transform DoorTransform;

		public global::UnityEngine.Transform ClosedPosition;

		public global::UnityEngine.Transform OpenPosition;

		public float SlideDuration;

		public global::UnityEngine.AnimationCurve SlideCurve;

		private global::UnityEngine.Coroutine MoveRoutine;

		public bool IsOpen { get; protected set; }

		public virtual void Opened(global::ScheduleOne.Doors.EDoorSide openSide)
		{
		}

		public virtual void Closed()
		{
		}

		private void Move()
		{
		}
	}
}
