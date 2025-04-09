using ScheduleOne.DevUtilities;
using UnityEngine;
using VLB;

namespace ScheduleOne.Lighting
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	[RequireComponent(typeof(VolumetricLightBeamSD))]
	public class VolumetricLightTracker : MonoBehaviour
	{
		public bool Override;

		public bool Enabled;

		public Light light;

		public OptimizedLight optimizedLight;

		public VolumetricLightBeamSD beam;

		public VolumetricDustParticles dust;

		private void OnValidate()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
