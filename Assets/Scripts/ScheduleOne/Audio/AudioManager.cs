namespace ScheduleOne.Audio
{
	public class AudioManager : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.Audio.AudioManager>
	{
		private const float MinGameVolume = 0.0001f;

		private const float MaxGameVolume = 1f;

		private const float GameVolumeLerpSpeed = 2f;

		public global::System.Action onVolumeSettingsChanged;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Audio.AudioMixerSnapshot _defaultSnapshot;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Audio.AudioMixerSnapshot _distortedSnapshot;

		private float _masterVolume;

		private float _ambientVolume;

		private float _footstepsVolume;

		private float _fxVolume;

		private float _uiVolume;

		private float _musicVolume;

		private float _voiceVolume;

		private float _currentMainMixerVolume;

		public float MasterVolume => 0f;

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Audio.AudioMixerGroup MainGameMixer { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Audio.AudioMixerGroup MenuMixer { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Audio.AudioMixerGroup MusicMixer { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		public void SetDistorted(bool distorted, float transition = 5f)
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

		private void SetMainMixerVolume(float value)
		{
		}

		private static float ValueToVolume(float value)
		{
			return 0f;
		}
	}
}
