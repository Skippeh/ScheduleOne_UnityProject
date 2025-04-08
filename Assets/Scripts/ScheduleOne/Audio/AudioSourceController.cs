namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.AudioSource))]
	public class AudioSourceController : global::UnityEngine.MonoBehaviour
	{
		public bool DEBUG;

		public global::UnityEngine.AudioSource AudioSource;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.Audio.EAudioType AudioType;

		[global::UnityEngine.Range(0f, 1f)]
		public float DefaultVolume;

		public bool RandomizePitch;

		public float MinPitch;

		public float MaxPitch;

		[global::UnityEngine.Range(0f, 2f)]
		public float VolumeMultiplier;

		[global::UnityEngine.Range(0f, 2f)]
		public float PitchMultiplier;

		private bool paused;

		private bool isPlayingCached;

		private float basePitch;

		public float Volume { get; protected set; }

		public bool isPlaying => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void DoPauseStuff()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnValidate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Pause()
		{
		}

		private void Unpause()
		{
		}

		public void SetVolume(float volume)
		{
		}

		public void ApplyVolume()
		{
		}

		public void ApplyPitch()
		{
		}

		public virtual void Play()
		{
		}

		public virtual void PlayOneShot(bool duplicateAudioSource = false)
		{
		}

		public void Stop()
		{
		}
	}
}
