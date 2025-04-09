using System.Runtime.CompilerServices;
using UnityEngine;

namespace Funly.SkyStudio
{
	[ExecuteInEditMode]
	public class TimeOfDayController : MonoBehaviour
	{
		public delegate void TimeOfDayDidChange(TimeOfDayController tc, float timeOfDay);

		[Tooltip("Sky profile defines the skyColors configuration for times of day. This script will animate between those skyColors values based on the time of day.")]
		[SerializeField]
		private SkyProfile m_SkyProfile;

		[Tooltip("Time is expressed in a fractional number of days that have completed.")]
		[SerializeField]
		private float m_SkyTime;

		[Tooltip("Automatically advance time at fixed speed.")]
		public bool automaticTimeIncrement;

		[Tooltip("Create a copy of the sky profile at runtime, so modifications don't affect the original Sky Profile in your project.")]
		public bool copySkyProfile;

		private SkyMaterialController m_SkyMaterialController;

		[Tooltip("Speed at which to advance time by if in automatic increment is enabled.")]
		[Range(0f, 1f)]
		public float automaticIncrementSpeed;

		[Tooltip("Sun orbit.")]
		public OrbitingBody sunOrbit;

		[Tooltip("Moon orbit.")]
		public OrbitingBody moonOrbit;

		[Tooltip("Controller for managing weather effects")]
		public WeatherController weatherController;

		[Tooltip("If true we'll invoke DynamicGI.UpdateEnvironment() when skybox changes. This is an expensive operation.")]
		public bool updateGlobalIllumination;

		[Tooltip("Configurable prefab that determines how to animate between 2 sky profiles. You can override individual feature animations, ex: 'skyBlender', to create a custom sky blending effect.")]
		public BlendSkyProfiles skyProfileTransitionPrefab;

		private bool m_DidInitialUpdate;

		public static TimeOfDayController instance { get; private set; }

		public SkyProfile skyProfile
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

		public SkyMaterialController SkyMaterial => null;

		public float timeOfDay => 0f;

		public int daysElapsed => 0;

		public event TimeOfDayDidChange timeChangedCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
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

		private Vector3 GetPrimaryLightDirection()
		{
			return default(Vector3);
		}

		public bool StartSkyProfileTransition(SkyProfile toProfile, float duration = 1f)
		{
			return false;
		}

		public void CancelSkyProfileTransition()
		{
		}

		public void OnBlendComplete(BlendSkyProfiles blender)
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
