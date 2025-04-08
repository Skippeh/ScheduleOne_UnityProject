namespace ScheduleOne.Lighting
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Light))]
	[global::UnityEngine.RequireComponent(typeof(global::VLB.VolumetricLightBeamSD))]
	public class VolumetricLightTracker : global::UnityEngine.MonoBehaviour
	{
		public bool Override;

		public bool Enabled;

		public global::UnityEngine.Light light;

		public global::ScheduleOne.DevUtilities.OptimizedLight optimizedLight;

		public global::VLB.VolumetricLightBeamSD beam;

		public global::VLB.VolumetricDustParticles dust;

		private void OnValidate()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
