using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.GameTime
{
	public class AnalogueClock : MonoBehaviour
	{
		public Transform MinHand;

		public Transform HourHand;

		public Vector3 RotationAxis;

		public UnityEvent onNoon;

		public UnityEvent onMidnight;

		public void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void MinPass()
		{
		}
	}
}
