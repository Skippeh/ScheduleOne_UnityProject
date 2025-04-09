using UnityEngine;

namespace ScheduleOne.Doors
{
	public class PivotDoor : MonoBehaviour
	{
		[Header("Settings")]
		public Transform DoorTransform;

		public bool FlipSide;

		public float OpenInwardsAngle;

		public float OpenOutwardsAngle;

		public float SwingSpeed;

		private float targetDoorAngle;

		protected virtual void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public virtual void Opened(EDoorSide openSide)
		{
		}

		public virtual void Closed()
		{
		}
	}
}
