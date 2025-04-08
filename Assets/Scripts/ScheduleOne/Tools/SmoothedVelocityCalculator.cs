namespace ScheduleOne.Tools
{
	public class SmoothedVelocityCalculator : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Vector3 Velocity;

		[global::UnityEngine.Header("Settings")]
		public float SampleLength;

		public float MaxReasonableVelocity;

		private global::System.Collections.Generic.List<global::System.Tuple<global::UnityEngine.Vector3, float>> VelocityHistory;

		private int maxSamples;

		private global::UnityEngine.Vector3 lastFramePosition;

		private bool zeroOut;

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
	}
}
