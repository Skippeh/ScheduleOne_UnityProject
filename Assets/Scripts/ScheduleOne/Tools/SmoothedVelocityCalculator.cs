namespace ScheduleOne.Tools
{
	public class SmoothedVelocityCalculator : global::UnityEngine.MonoBehaviour
	{
		private const int sampleCount = 20;

		public bool DEBUG;

		[global::UnityEngine.Header("Settings")]
		public float SampleLength;

		public float MaxReasonableVelocity;

		private CircularQueue<global::UnityEngine.Vector3> velocityHistory;

		private global::UnityEngine.Vector3 lastSamplePosition;

		private float timeOnLastSample;

		private float timeSinceLastSample;

		private bool zeroOut;

		public global::UnityEngine.Vector3 Velocity { get; protected set; }

		public global::UnityEngine.Transform Target { get; private set; }

		private void Start()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		private global::UnityEngine.Vector3 GetAverageVelocity()
		{
			return default(global::UnityEngine.Vector3);
		}

		public void FlushBuffer()
		{
		}

		public void ZeroOut(float duration)
		{
		}

		public void SetTarget(global::UnityEngine.Transform target)
		{
		}
	}
}
