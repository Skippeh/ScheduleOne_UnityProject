namespace VLB
{
	[global::UnityEngine.AddComponentMenu("")]
	public class EffectAbstractBase : global::UnityEngine.MonoBehaviour
	{
		[global::System.Flags]
		public enum ComponentsToChange
		{
			UnityLight = 1,
			VolumetricLightBeam = 2,
			VolumetricDustParticles = 4
		}

		public const string ClassName = "EffectAbstractBase";

		public global::VLB.EffectAbstractBase.ComponentsToChange componentsToChange;

		[global::UnityEngine.Serialization.FormerlySerializedAs("restoreBaseIntensity")]
		public bool restoreIntensityOnDisable;

		protected global::VLB.VolumetricLightBeamAbstractBase m_Beam;

		protected global::UnityEngine.Light m_Light;

		protected global::VLB.VolumetricDustParticles m_Particles;

		protected float m_BaseIntensityBeamInside;

		protected float m_BaseIntensityBeamOutside;

		protected float m_BaseIntensityLight;

		[global::System.Obsolete("Use 'restoreIntensityOnDisable' instead")]
		public bool restoreBaseIntensity
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void InitFrom(global::VLB.EffectAbstractBase Source)
		{
		}

		private void GetIntensity(global::VLB.VolumetricLightBeamSD beam)
		{
		}

		private void GetIntensity(global::VLB.VolumetricLightBeamHD beam)
		{
		}

		private void SetIntensity(global::VLB.VolumetricLightBeamSD beam, float additive)
		{
		}

		private void SetIntensity(global::VLB.VolumetricLightBeamHD beam, float additive)
		{
		}

		protected void SetAdditiveIntensity(float additive)
		{
		}

		private void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
