namespace ScheduleOne.Weather
{
	public class WeatherEffectController : global::ScheduleOne.Effects.EffectController
	{
		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Weather.ParticleEffectHandler> particleEffects;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Effects.VFXEffectHandler> visualEffects;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Weather.ShaderEffectHandler> shaderEffects;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Audio.AudioSourceController> _audioSources;

		[global::UnityEngine.Header("Parameters: general")]
		[global::UnityEngine.SerializeField]
		protected string _controllerId;

		[global::UnityEngine.Header("Parameters: Audio")]
		[global::UnityEngine.Tooltip("Min and max distance for audio effects. Max being the distance at which audio is inaudible, and min being the distance at which audio is at full volume")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Vector2 _minMaxDistanceToPlayer;

		[global::UnityEngine.Tooltip("Uses the blend value of weather volume to determine audio volume rather than distance to player")]
		[global::UnityEngine.SerializeField]
		protected bool _useWeatherBlendForAudio;

		[global::UnityEngine.Tooltip("Used to evaluate audio blending of audio volume (when using distance to player)")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve _distanceCurve;

		[global::UnityEngine.Tooltip("Used to evaluate audio blending from inside to outside")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve _enclosureCurve;

		[global::UnityEngine.Header("Parameters: Effects")]
		[global::UnityEngine.Header("Settings: Player Following")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Effects.EffectHandler> _effectsToFollowPlayer;

		[global::UnityEngine.Header("Settings: Effects")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Effects.EffectSettings> _effectSettings;

		[global::UnityEngine.Header("Settings: Audio")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Audio.AudioSettings> _audioSettings;

		[global::UnityEngine.Header("Debugging & Development")]
		[global::UnityEngine.SerializeField]
		protected bool _showGizmos;

		protected float _weatherBlend;

		protected global::ScheduleOne.Weather.WeatherVolume _mainVolume;

		protected global::ScheduleOne.Weather.WeatherVolume _neighbourVolume;

		private bool NetworkInitialize___EarlyScheduleOne_002EWeather_002EWeatherEffectControllerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EWeather_002EWeatherEffectControllerAssembly_002DCSharp_002Edll_Excuted;

		public string ControllerId => null;

		public override void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		public void Initialise(global::ScheduleOne.Weather.WeatherVolume mainVolume)
		{
		}

		public void SetNeighbourVolume(global::ScheduleOne.Weather.WeatherVolume neighbourVolume)
		{
		}

		public override void Activate()
		{
		}

		public override void Deactivate()
		{
		}

		public void BlendEffects(float blend, global::UnityEngine.AnimationCurve curve)
		{
		}

		private void SetEffectParamters(global::ScheduleOne.Effects.EffectHandler effectHandler, float blend, global::UnityEngine.AnimationCurve curve)
		{
		}

		public void SetShaderNumericParameter(string paramater, float value)
		{
		}

		public void SetVisualEffectNumericParameter(string paramater, float value)
		{
		}

		public void SetShaderColorParameter(string paramater, global::UnityEngine.Color value)
		{
		}

		public global::ScheduleOne.Effects.EffectSettings FindEffectSettings(string handlerId)
		{
			return null;
		}

		protected virtual global::ScheduleOne.Effects.EffectSettings GetFromEffectSettings(string handlerId)
		{
			return null;
		}

		public virtual void UpdateAudio()
		{
		}

		public override void UpdateProperties(global::UnityEngine.Vector3 anchoredPosition, global::UnityEngine.Vector3 playerPosition, float sqrDistanceToPlayer, float enclosureBlend)
		{
		}

		private void OnDrawGizmos()
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EWeather_002EWeatherEffectController_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
