using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	public class AverageAcceleration : MonoBehaviour
	{
		public Rigidbody Rb;

		public float TimeWindow;

		private Vector3[] accelerations;

		private int currentIndex;

		private float timer;

		private Vector3 prevVelocity;

		public Vector3 Acceleration { get; private set; }

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
