namespace Funly.SkyStudio
{
	[global::UnityEngine.ExecuteInEditMode]
	public class TimeOfDayController : global::UnityEngine.MonoBehaviour
	{
		public delegate void TimeOfDayDidChange(global::Funly.SkyStudio.TimeOfDayController tc, float timeOfDay);

		[global::UnityEngine.Tooltip("Sky profile defines the skyColors configuration for times of day. This script will animate between those skyColors values based on the time of day.")]
		[global::UnityEngine.SerializeField]
		private global::Funly.SkyStudio.SkyProfile m_SkyProfile;

		[global::UnityEngine.Tooltip("Time is expressed in a fractional number of days that have completed.")]
		[global::UnityEngine.SerializeField]
		private float m_SkyTime;

		[global::UnityEngine.Tooltip("Automatically advance time at fixed speed.")]
		public bool automaticTimeIncrement;

		[global::UnityEngine.Tooltip("Create a copy of the sky profile at runtime, so modifications don't affect the original Sky Profile in your project.")]
		public bool copySkyProfile;

		private global::Funly.SkyStudio.SkyMaterialController m_SkyMaterialController;

		[global::UnityEngine.Tooltip("Speed at which to advance time by if in automatic increment is enabled.")]
		[global::UnityEngine.Range(0f, 1f)]
		public float automaticIncrementSpeed;

		[global::UnityEngine.Tooltip("Sun orbit.")]
		public global::Funly.SkyStudio.OrbitingBody sunOrbit;

		[global::UnityEngine.Tooltip("Moon orbit.")]
		public global::Funly.SkyStudio.OrbitingBody moonOrbit;

		[global::UnityEngine.Tooltip("Controller for managing weather effects")]
		public global::Funly.SkyStudio.WeatherController weatherController;

		[global::UnityEngine.Tooltip("If true we'll invoke DynamicGI.UpdateEnvironment() when skybox changes. This is an expensive operation.")]
		public bool updateGlobalIllumination;

		[global::UnityEngine.Tooltip("Configurable prefab that determines how to animate between 2 sky profiles. You can override individual feature animations, ex: 'skyBlender', to create a custom sky blending effect.")]
		public global::Funly.SkyStudio.BlendSkyProfiles skyProfileTransitionPrefab;

		[global::UnityEngine.Header("Overrides")]
		public global::Funly.SkyStudio.SkyProfileOverride[] SkyProfileOverrideStack;

		private bool m_DidInitialUpdate;

		public static global::Funly.SkyStudio.TimeOfDayController instance { get; private set; }

		public global::Funly.SkyStudio.SkyProfile skyProfile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float skyTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::Funly.SkyStudio.SkyMaterialController SkyMaterial => null;

		public float timeOfDay => 0f;

		public int daysElapsed => 0;

		public event global::Funly.SkyStudio.TimeOfDayController.TimeOfDayDidChange timeChangedCallback
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnabled()
		{
		}

		private void OnValidate()
		{
		}

		private void WarnInvalidSkySetup()
		{
		}

		private void Update()
		{
		}

		public void UpdateGlobalIllumination()
		{
		}

		private void SynchronizeAllShaderKeywords()
		{
		}

		private void SynchronizedShaderKeyword(string featureKey, string shaderKeyword)
		{
		}

		private global::UnityEngine.Vector3 GetPrimaryLightDirection()
		{
			return default(global::UnityEngine.Vector3);
		}

		public bool StartSkyProfileTransition(global::Funly.SkyStudio.SkyProfile toProfile, float duration = 1f)
		{
			return false;
		}

		public void CancelSkyProfileTransition()
		{
		}

		public void OnBlendComplete(global::Funly.SkyStudio.BlendSkyProfiles blender)
		{
		}

		public bool IsBlendingInProgress()
		{
			return false;
		}

		public void UpdateSkyForCurrentTime()
		{
		}
	}
}
