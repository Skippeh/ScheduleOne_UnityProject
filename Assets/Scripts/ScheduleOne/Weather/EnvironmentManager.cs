namespace ScheduleOne.Weather
{
	public class EnvironmentManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Weather.EnvironmentManager>
	{
		[global::UnityEngine.Header("General Components")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _playerObj;

		[global::UnityEngine.Header("Controllers")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.DayNightController _dayNightController;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.MaskController _maskController;

		[global::UnityEngine.Header("Weather Components")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _weatherBoundsAnchor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _weatherVolumeContainer;

		[global::UnityEngine.Header("Weather Profiles")]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Weather.WeatherSequence> _weatherSequences;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Weather.WeightedWeatherSequence> _dailyWeatherSequences;

		[global::UnityEngine.Header("Weather Settings")]
		[global::UnityEngine.SerializeField]
		private float _defaultWeatherVolumeMoveSpeed;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(1f, 6f)]
		private int _weatherVolumeCount;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector3 _weatherBounds;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _weatherVolumeBlendSize;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.AnimationCurve _blendCurve;

		[global::UnityEngine.Header("Lighting Settings")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.LensFlareSettings _lensFlareSettings;

		[global::UnityEngine.Header("Debugging & Development")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Rendering.Universal.UniversalRendererData _rendererData;

		[global::UnityEngine.SerializeField]
		private bool _debugControlWeatherSpeedWithSlider;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _debugWeatherSliderValue;

		private global::System.Collections.Generic.List<global::ScheduleOne.Weather.WeatherEnclosure> _weatherEnclosures;

		private global::System.Collections.Generic.List<global::ScheduleOne.Weather.SkyOverrideEnclosure> _overrideEnclosures;

		private global::System.Collections.Generic.List<global::ScheduleOne.Weather.PuddleVolume> _puddleVolumes;

		[global::FishNet.Object.Synchronizing.SyncObject]
		private readonly global::FishNet.Object.Synchronizing.SyncList<global::ScheduleOne.Weather.WeatherVolume> _activeWeatherVolumes;

		private global::ScheduleOne.Weather.WeatherSequence _currentWeatherSequence;

		private global::ScheduleOne.Weather.WeatherVolume _targetWeatherVolume;

		private global::UnityEngine.Vector3 _weatherVolumeBounds;

		private global::UnityEngine.Vector3 _weatherBoundsCenter;

		private global::ScheduleOne.Weather.SkySettings _skyOverrideSettings;

		private float _skyOverrideBlendValue;

		private bool _doWeatherBlending;

		private bool _hasWeatherVolumeNeighbour;

		private bool _withinBounds;

		private int _targetWeatherVolumeIndex;

		private int _neighbourWeatherVolumeIndex;

		private float _targetWeatherBlendValue;

		private float _weatherVolumeMoveSpeed;

		private float _neighbourWeatherBlendValue;

		private global::UnityEngine.Vector2 _closestPointInTargetVolume;

		private global::UnityEngine.Vector2 _closestPointInNeighbourVolume;

		private float _wetUpdateTimer;

		private int _sequenceVolumeStartIndex;

		private global::UnityEngine.Vector3[] _weatherVolumePositions;

		private global::ScheduleOne.Weather.WeatherConditions _currentWeatherConditions;

		private global::ScheduleOne.Weather.SkyState _currentSkyState;

		protected ScheduleOneFogFeature _fogFeature;

		private global::System.Collections.Generic.List<global::ScheduleOne.Weather.IWeatherEntity> _registeredWeatherEntities;

		private bool NetworkInitialize___EarlyScheduleOne_002EWeather_002EEnvironmentManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EWeather_002EEnvironmentManagerAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Weather.WeatherConditions CurrentWeatherConditions => null;

		public global::ScheduleOne.Weather.SkyState CurrentSkyState => null;

		protected global::UnityEngine.Transform Player => null;

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void OnStartServer()
		{
		}

		private void Update()
		{
		}

		private void InitialiseControllers()
		{
		}

		private void InitialiseSky()
		{
		}

		private void InitialiseWeather()
		{
		}

		private void InitialiseGlobalVariables()
		{
		}

		private void CreateWeatherVolumesAtStartIndex(int sequenceVolumeIndex)
		{
		}

		private void CreateVolume(global::ScheduleOne.Weather.WeatherVolume volume, global::UnityEngine.Vector3 position, int insertIndex = -1)
		{
		}

		private global::ScheduleOne.Weather.WeatherProfile GetNextWeatherProfile(global::ScheduleOne.Weather.WeatherProfile currentProfile)
		{
			return null;
		}

		private void DetermineWeatherVolumeWithTarget()
		{
		}

		private void CalculateWeatherBlendsFromVolumes()
		{
		}

		private void BlendWeatherProfiles()
		{
		}

		private void CreateWeatherVolumes()
		{
		}

		private void MoveWeatherVolumes()
		{
		}

		public int GetSequenceStartTime(global::ScheduleOne.Weather.WeatherSequence sequence)
		{
			return 0;
		}

		private void UpdateVolumes()
		{
		}

		private void UpdateWeather()
		{
		}

		private void UpdateWeatherEntities()
		{
		}

		private void SetRandomWeatherSequence()
		{
		}

		private void SetLensFlare(global::UnityEngine.Rendering.LensFlareDataSRP flare, float intensity)
		{
		}

		private void ClearWeather()
		{
		}

		public void RegisterEnclosure(global::ScheduleOne.Weather.WorldEnclosure enclosure)
		{
		}

		private void RegisterWeatherEnclosure(global::ScheduleOne.Weather.WeatherEnclosure enclosure)
		{
		}

		private void RegisterOverrideEnclosure(global::ScheduleOne.Weather.SkyOverrideEnclosure enclosure)
		{
		}

		public void RegisterPuddleVolume(global::ScheduleOne.Weather.PuddleVolume puddleVolume)
		{
		}

		private void SetWeatherConditions(global::ScheduleOne.Weather.WeatherConditions conditions)
		{
		}

		protected global::ScheduleOne.Weather.WeatherProfile GetWeatherProfileFromPosition(global::UnityEngine.Vector3 position)
		{
			return null;
		}

		public global::ScheduleOne.Weather.WeatherConditions GetActiveWeatherConditionsFromPosition(global::UnityEngine.Vector3 position)
		{
			return null;
		}

		private global::UnityEngine.Vector3 GetWeatherVolumeBounds()
		{
			return default(global::UnityEngine.Vector3);
		}

		private global::UnityEngine.Vector3 GetWeatherVolumeInitialPosition()
		{
			return default(global::UnityEngine.Vector3);
		}

		private global::UnityEngine.Vector3 GetWeatherBoundsCenter()
		{
			return default(global::UnityEngine.Vector3);
		}

		private global::UnityEngine.Transform GetWeatherAnchor()
		{
			return null;
		}

		private void OnMinutePass()
		{
		}

		private void OnTick()
		{
		}

		public void OnTimeSet()
		{
		}

		public void OnSleepEnd()
		{
		}

		private global::UnityEngine.Transform GetPlayer()
		{
			return null;
		}

		public bool IsPositionUnderCover(global::UnityEngine.Vector3 position)
		{
			return false;
		}

		public void OnWeatherEntityRegistered(global::ScheduleOne.Weather.IWeatherEntity entity)
		{
		}

		public void OnWeatherEntityUnregistered(global::ScheduleOne.Weather.IWeatherEntity entity)
		{
		}

		protected override void OnDestroy()
		{
		}

		[global::ScheduleOne.Core.Button]
		public void SetDebugSequence()
		{
		}

		[global::ScheduleOne.Core.Button]
		public void SetWeather(string type)
		{
		}

		private void SetWeatherSequence(string sequenceId)
		{
		}

		public void StopVolumeMovement()
		{
		}

		public void StartVolumeMovement()
		{
		}

		public void SetVolumeMoveSpeed(float speed)
		{
		}

		public void TriggerLightningEvent()
		{
		}

		public void TriggerPlayerLightningEvent(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public void TriggerNpcLightningEvent(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public void TriggerDistantThunder()
		{
		}

		private global::ScheduleOne.Weather.ThunderController GetActiveThunderController()
		{
			return null;
		}

		private void SetWeather_Client()
		{
		}

		private void SetWeatherSpeed_Client()
		{
		}

		private void TriggerThunder_Client()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002EWeather_002EEnvironmentManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
