namespace Funly.SkyStudio
{
	public class BlendSkyProfiles : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Tooltip("Called when blending finishes.")]
		public global::System.Action<global::Funly.SkyStudio.BlendSkyProfiles> onBlendComplete;

		[global::UnityEngine.HideInInspector]
		private float m_StartTime;

		[global::UnityEngine.HideInInspector]
		private float m_EndTime;

		[global::UnityEngine.Tooltip("Blender used for basic sky background properties.")]
		public global::Funly.SkyStudio.FeatureBlender skyBlender;

		[global::UnityEngine.Tooltip("Blender used for the sun properties.")]
		public global::Funly.SkyStudio.FeatureBlender sunBlender;

		[global::UnityEngine.Tooltip("Blender used moon properties.")]
		public global::Funly.SkyStudio.FeatureBlender moonBlender;

		[global::UnityEngine.Tooltip("Blender used cloud properties.")]
		public global::Funly.SkyStudio.FeatureBlender cloudBlender;

		[global::UnityEngine.Tooltip("Blender used star layer 1 properties.")]
		public global::Funly.SkyStudio.FeatureBlender starLayer1Blender;

		[global::UnityEngine.Tooltip("Blender used star layer 2 properties.")]
		public global::Funly.SkyStudio.FeatureBlender starLayer2Blender;

		[global::UnityEngine.Tooltip("Blender used star layer 3 properties.")]
		public global::Funly.SkyStudio.FeatureBlender starLayer3Blender;

		[global::UnityEngine.Tooltip("Blender used by the rain downfall feature.")]
		public global::Funly.SkyStudio.FeatureBlender rainBlender;

		[global::UnityEngine.Tooltip("Blender used by the rain splash feature.")]
		public global::Funly.SkyStudio.FeatureBlender rainSplashBlender;

		[global::UnityEngine.Tooltip("Blender used for lightning feature properties.")]
		public global::Funly.SkyStudio.FeatureBlender lightningBlender;

		[global::UnityEngine.Tooltip("Blender used for fog properties.")]
		public global::Funly.SkyStudio.FeatureBlender fogBlender;

		private bool m_IsBlendingFirstHalf;

		private global::Funly.SkyStudio.ProfileBlendingState m_State;

		private global::Funly.SkyStudio.TimeOfDayController m_TimeOfDayController;

		private global::Funly.SkyStudio.BlendingHelper blendingHelper;

		public global::Funly.SkyStudio.SkyProfile fromProfile { get; private set; }

		public global::Funly.SkyStudio.SkyProfile toProfile { get; private set; }

		public global::Funly.SkyStudio.SkyProfile blendedProfile { get; private set; }

		public global::Funly.SkyStudio.SkyProfile StartBlending(global::Funly.SkyStudio.TimeOfDayController controller, global::Funly.SkyStudio.SkyProfile fromProfile, global::Funly.SkyStudio.SkyProfile toProfile, float duration)
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

		private float PercentForMode(global::Funly.SkyStudio.ProfileFeatureBlendingMode mode, float percent)
		{
			return 0f;
		}
	}
}
