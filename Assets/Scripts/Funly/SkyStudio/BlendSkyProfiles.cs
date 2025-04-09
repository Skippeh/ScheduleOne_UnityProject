using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	public class BlendSkyProfiles : MonoBehaviour
	{
		[Tooltip("Called when blending finishes.")]
		public Action<BlendSkyProfiles> onBlendComplete;

		[HideInInspector]
		private float m_StartTime;

		[HideInInspector]
		private float m_EndTime;

		[Tooltip("Blender used for basic sky background properties.")]
		public FeatureBlender skyBlender;

		[Tooltip("Blender used for the sun properties.")]
		public FeatureBlender sunBlender;

		[Tooltip("Blender used moon properties.")]
		public FeatureBlender moonBlender;

		[Tooltip("Blender used cloud properties.")]
		public FeatureBlender cloudBlender;

		[Tooltip("Blender used star layer 1 properties.")]
		public FeatureBlender starLayer1Blender;

		[Tooltip("Blender used star layer 2 properties.")]
		public FeatureBlender starLayer2Blender;

		[Tooltip("Blender used star layer 3 properties.")]
		public FeatureBlender starLayer3Blender;

		[Tooltip("Blender used by the rain downfall feature.")]
		public FeatureBlender rainBlender;

		[Tooltip("Blender used by the rain splash feature.")]
		public FeatureBlender rainSplashBlender;

		[Tooltip("Blender used for lightning feature properties.")]
		public FeatureBlender lightningBlender;

		[Tooltip("Blender used for fog properties.")]
		public FeatureBlender fogBlender;

		private bool m_IsBlendingFirstHalf;

		private ProfileBlendingState m_State;

		private TimeOfDayController m_TimeOfDayController;

		private BlendingHelper blendingHelper;

		public SkyProfile fromProfile { get; private set; }

		public SkyProfile toProfile { get; private set; }

		public SkyProfile blendedProfile { get; private set; }

		public SkyProfile StartBlending(TimeOfDayController controller, SkyProfile fromProfile, SkyProfile toProfile, float duration)
		{
			return null;
		}

		public void CancelBlending()
		{
		}

		public void TearDownBlending()
		{
		}

		private void Update()
		{
		}

		private void UpdateBlendedProfile()
		{
		}

		private float PercentForMode(ProfileFeatureBlendingMode mode, float percent)
		{
			return 0f;
		}
	}
}
