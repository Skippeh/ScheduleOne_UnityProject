using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	[AddComponentMenu("")]
	public class EffectAbstractBase : MonoBehaviour
	{
		[Flags]
		public enum ComponentsToChange
		{
			UnityLight = 1,
			VolumetricLightBeam = 2,
			VolumetricDustParticles = 4
		}

		public const string ClassName = "EffectAbstractBase";

		public ComponentsToChange componentsToChange;

		[FormerlySerializedAs("restoreBaseIntensity")]
		public bool restoreIntensityOnDisable;

		protected VolumetricLightBeamAbstractBase m_Beam;

		protected Light m_Light;

		protected VolumetricDustParticles m_Particles;

		protected float m_BaseIntensityBeamInside;

		protected float m_BaseIntensityBeamOutside;

		protected float m_BaseIntensityLight;

		[Obsolete("Use 'restoreIntensityOnDisable' instead")]
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

		public virtual void InitFrom(EffectAbstractBase Source)
		{
		}

		private void GetIntensity(VolumetricLightBeamSD beam)
		{
		}

		private void GetIntensity(VolumetricLightBeamHD beam)
		{
		}

		private void SetIntensity(VolumetricLightBeamSD beam, float additive)
		{
		}

		private void SetIntensity(VolumetricLightBeamHD beam, float additive)
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
