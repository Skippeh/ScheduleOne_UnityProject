namespace ScheduleOne.Map.Infrastructure
{
	public class StreetLight : global::UnityEngine.MonoBehaviour
	{
		public static global::UnityEngine.Vector3 POWER_ORIGIN;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.MeshRenderer LightRend;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Light Light;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Lighting.VolumetricLightTracker BeamTracker;

		[global::UnityEngine.Header("Materials")]
		public global::UnityEngine.Material LightOnMat;

		public global::UnityEngine.Material LightOffMat;

		[global::UnityEngine.Header("Timing")]
		public int StartTime;

		public int EndTime;

		public int StartTimeOffset;

		[global::UnityEngine.Header("Settings")]
		public bool ShadowsEnabled;

		public float LightMaxDistance;

		public float SoftShadowsThreshold;

		public float HardShadowsThreshold;

		private bool isOn;

		protected virtual void Awake()
		{
		}

		private void Start()
		{
		}

		protected virtual void UpdateState()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void SetState(bool on)
		{
		}

		private void UpdateShadows()
		{
		}
	}
}
