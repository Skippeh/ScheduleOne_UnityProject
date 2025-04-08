namespace ScheduleOne.DevUtilities
{
	public class AverageAcceleration : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Rigidbody Rb;

		public float TimeWindow;

		private global::UnityEngine.Vector3[] accelerations;

		private int currentIndex;

		private float timer;

		private global::UnityEngine.Vector3 prevVelocity;

		public global::UnityEngine.Vector3 Acceleration { get; private set; }

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
