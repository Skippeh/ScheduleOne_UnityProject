namespace ScheduleOne.Audio
{
	public class AudioManager : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.Audio.AudioManager>
	{
		public const float MIN_WORLD_MUSIC_VOLUME_MULTIPLIER = 0f;

		public const float MUSIC_FADE_TIME = 4f;

		[global::UnityEngine.Range(0f, 2f)]
		[global::UnityEngine.SerializeField]
		protected float masterVolume;

		[global::UnityEngine.Range(0f, 2f)]
		[global::UnityEngine.SerializeField]
		protected float ambientVolume;

		[global::UnityEngine.Range(0f, 2f)]
		[global::UnityEngine.SerializeField]
		protected float footstepsVolume;

		[global::UnityEngine.Range(0f, 2f)]
		[global::UnityEngine.SerializeField]
		protected float fxVolume;

		[global::UnityEngine.Range(0f, 2f)]
		[global::UnityEngine.SerializeField]
		protected float uiVolume;

		[global::UnityEngine.Range(0f, 2f)]
		[global::UnityEngine.SerializeField]
		protected float musicVolume;

		[global::UnityEngine.Range(0f, 2f)]
		[global::UnityEngine.SerializeField]
		protected float voiceVolume;

		public global::UnityEngine.Events.UnityEvent onSettingsChanged;

		[global::UnityEngine.Header("Generic Door Sounds")]
		public global::ScheduleOne.Audio.AudioSourceController DoorOpen;

		public global::ScheduleOne.Audio.AudioSourceController DoorClose;

		[global::UnityEngine.Header("Mixers")]
		public global::UnityEngine.Audio.AudioMixerGroup MainGameMixer;

		public global::UnityEngine.Audio.AudioMixerGroup MenuMixer;

		public global::UnityEngine.Audio.AudioMixerGroup MusicMixer;

		private float currentGameVolume;

		private const float minGameVolume = 0.0001f;

		private const float maxGameVolume = 0.0001f;

		private float gameVolumeMultiplier;

		public global::UnityEngine.Audio.AudioMixerSnapshot DefaultSnapshot;

		public global::UnityEngine.Audio.AudioMixerSnapshot DistortedSnapshot;

		public float MasterVolume => 0f;

		public float AmbientVolume => 0f;

		public float UnscaledAmbientVolume => 0f;

		public float FootstepsVolume => 0f;

		public float UnscaledFootstepsVolume => 0f;

		public float FXVolume => 0f;

		public float UnscaledFXVolume => 0f;

		public float UIVolume => 0f;

		public float UnscaledUIVolume => 0f;

		public float MusicVolume => 0f;

		public float UnscaledMusicVolume => 0f;

		public float VoiceVolume => 0f;

		public float UnscaledVoiceVolume => 0f;

		public float WorldMusicVolumeMultiplier { get; private set; }

		public float GetScaledMusicVolumeMultiplier(float min)
		{
			return 0f;
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected void Update()
		{
		}

		public void SetGameVolumeMultipler(float value)
		{
		}

		public void SetDistorted(bool distorted, float transition = 5f)
		{
		}

		private void SetGameVolume(float value)
		{
		}

		public float GetVolume(global::ScheduleOne.Audio.EAudioType audioType, bool scaled = true)
		{
			return 0f;
		}

		public void SetMasterVolume(float volume)
		{
		}

		public void SetVolume(global::ScheduleOne.Audio.EAudioType type, float volume)
		{
		}
	}
}
