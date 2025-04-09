using UnityEngine;

namespace ScheduleOne.Doors
{
	public class SlidingDoor : MonoBehaviour
	{
		[Header("Settings")]
		public Transform DoorTransform;

		public Transform ClosedPosition;

		public Transform OpenPosition;

		public float SlideDuration;

		public AnimationCurve SlideCurve;

		private Coroutine MoveRoutine;

		public bool IsOpen { get; protected set; }

		public virtual void Opened(EDoorSide openSide)
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
