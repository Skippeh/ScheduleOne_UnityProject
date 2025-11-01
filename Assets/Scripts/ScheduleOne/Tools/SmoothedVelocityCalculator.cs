namespace ScheduleOne.Tools
{
	public class SmoothedVelocityCalculator : global::UnityEngine.MonoBehaviour
	{
		private const int sampleCount = 20;

		public bool DEBUG;

		[global::UnityEngine.Header("Settings")]
		public float SampleLength;

		public float MaxReasonableVelocity;

		private RollingAverage<global::UnityEngine.Vector3> velocityHistory;

		private global::UnityEngine.Vector3 lastSamplePosition;

		private float timeOnLastSample;

		private float timeSinceLastSample;

		private bool zeroOut;

		private bool isTargetValid;

		public global::UnityEngine.Transform Target { get; private set; }

		public virtual global::UnityEngine.Vector3 Velocity => default(global::UnityEngine.Vector3);

		private void Start()
		{
		}

		protected virtual void FixedUpdate()
		{
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
