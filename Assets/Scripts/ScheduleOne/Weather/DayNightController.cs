namespace ScheduleOne.Weather
{
	public class DayNightController : global::UnityEngine.MonoBehaviour
	{
		private const float SunShadowStrength = 0.95f;

		private const float MoonShadowStrength = 0.95f;

		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.GameObject _lightPivot;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.MeshRenderer _skyRenderer;

		[global::UnityEngine.Header("Lights")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Light _sunLight;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Light _moonLight;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Light _ambientLight;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.AnimationCurve _fadeInCurve;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.AnimationCurve _fadeOutCurve;

		[global::UnityEngine.Header("Debugging & Development")]
		[global::UnityEngine.SerializeField]
		private float _debugTimeSpeed;

		[global::UnityEngine.SerializeField]
		private bool _enableDebugTimeControl;

		[global::UnityEngine.SerializeField]
		private bool _debugAutoUpdateTime;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 24f)]
		private float _timeInHours;

		private float _timePercentage;

		private bool _isDay;

		private global::UnityEngine.Quaternion _currentSunRotation;

		private global::UnityEngine.Quaternion _currentMoonRotation;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.DayNightPhaseTimes _dayNightPhaseTimes;

		public const float MAX_LIGHT_INTENSITY = 4f;

		public bool EnableDebugTimeControl => false;

		private void Update()
		{
		}

		public global::ScheduleOne.Weather.SkyState EvaluateSky(global::ScheduleOne.Weather.SkySettings activeSettings, global::ScheduleOne.Weather.SkySettings neighbourSettings, float blend, global::ScheduleOne.Weather.SkySettings overrideSkySettings = null, float overrideBlend = 0f)
		{
			return null;
		}

		private global::ScheduleOne.Weather.SkyState EvaluateSky(global::ScheduleOne.Weather.SkyState state, global::ScheduleOne.Weather.SkySettings activeSettings, global::ScheduleOne.Weather.SkySettings neighbourSettings, float blend, float timeInTwentyFourHour, float timePercentage)
		{
			return null;
		}

		private global::ScheduleOne.Weather.SkyState BlendSky(global::ScheduleOne.Weather.SkyState from, global::ScheduleOne.Weather.SkyState to, float blend)
		{
			return null;
		}

		public float EvaluateFloatByTimeOfDay(DynamicGradient gradient)
		{
			return 0f;
		}

		public global::UnityEngine.Color EvaluateColorByTimeOfDay(DynamicGradient gradient)
		{
			return default(global::UnityEngine.Color);
		}

		private void UpdateSky(global::ScheduleOne.Weather.SkyState skyState)
		{
		}

		private void SetLights(bool isDay)
		{
		}

		private void UpdateRotation()
		{
		}

		private void SnapRotation()
		{
		}

		public void SetRotation()
		{
		}

		public void OnTick(float normalisedTime)
		{
		}

		public void OnTimeSet(float normalisedTime)
		{
		}

		private bool IsDay(float timeInTwentyFourHour)
		{
			return false;
		}
	}
}
