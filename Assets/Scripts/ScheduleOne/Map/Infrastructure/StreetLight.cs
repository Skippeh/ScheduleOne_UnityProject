using ScheduleOne.Lighting;
using UnityEngine;

namespace ScheduleOne.Map.Infrastructure
{
	public class StreetLight : MonoBehaviour
	{
		public static Vector3 POWER_ORIGIN;

		[Header("References")]
		[SerializeField]
		protected MeshRenderer LightRend;

		[SerializeField]
		protected Light Light;

		[SerializeField]
		protected VolumetricLightTracker BeamTracker;

		[Header("Materials")]
		public Material LightOnMat;

		public Material LightOffMat;

		[Header("Timing")]
		public int StartTime;

		public int EndTime;

		public int StartTimeOffset;

		[Header("Settings")]
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
