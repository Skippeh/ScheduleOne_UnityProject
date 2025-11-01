namespace ScheduleOne.Lighting
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Light))]
	[global::UnityEngine.RequireComponent(typeof(global::VLB.VolumetricLightBeamSD))]
	public class VolumetricLightTracker : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("Override")]
		private bool _Override;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("Enabled")]
		private bool _Enabled;

		public global::UnityEngine.Light light;

		public global::ScheduleOne.DevUtilities.OptimizedLight optimizedLight;

		public global::VLB.VolumetricLightBeamSD beam;

		public global::VLB.VolumetricDustParticles dust;

		public bool Override
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void AssignReferences()
		{
		}

		private void UpdateEffectsState()
		{
		}

		private void Awake()
		{
		}
	}
}
