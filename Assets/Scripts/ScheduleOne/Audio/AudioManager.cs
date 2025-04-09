using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace ScheduleOne.Audio
{
	public class AudioManager : PersistentSingleton<AudioManager>
	{
		[Range(0f, 2f)]
		[SerializeField]
		protected float masterVolume;

		[Range(0f, 2f)]
		[SerializeField]
		protected float ambientVolume;

		[Range(0f, 2f)]
		[SerializeField]
		protected float footstepsVolume;

		[Range(0f, 2f)]
		[SerializeField]
		protected float fxVolume;

		[Range(0f, 2f)]
		[SerializeField]
		protected float uiVolume;

		[Range(0f, 2f)]
		[SerializeField]
		protected float musicVolume;

		[Range(0f, 2f)]
		[SerializeField]
		protected float voiceVolume;

		public UnityEvent onSettingsChanged;

		[Header("Generic Door Sounds")]
		public AudioSourceController DoorOpen;

		public AudioSourceController DoorClose;

		[Header("Mixers")]
		public AudioMixerGroup MainGameMixer;

		public AudioMixerGroup MenuMixer;

		public AudioMixerGroup MusicMixer;

		private float currentGameVolume;

		private const float minGameVolume = 0.0001f;

		private const float maxGameVolume = 0.0001f;

		private float gameVolumeMultiplier;

		public AudioMixerSnapshot DefaultSnapshot;

		public AudioMixerSnapshot DistortedSnapshot;

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

		public float GetVolume(EAudioType audioType, bool scaled = true)
		{
			return 0f;
		}

		public void SetMasterVolume(float volume)
		{
		}

		public void SetVolume(EAudioType type, float volume)
		{
		}
	}
}
