namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Audio.AudioSourceController))]
	public class MusicTrack : global::UnityEngine.MonoBehaviour
	{
		public bool Enabled;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("TrackName")]
		private string _trackName;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("Priority")]
		private int _priority;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("VolumeMultiplier")]
		protected float _volumeMultiplier;

		[global::UnityEngine.Serialization.FormerlySerializedAs("FadeInTime")]
		[global::UnityEngine.SerializeField]
		protected float _fadeInTime;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("FadeOutTime")]
		protected float _fadeOutTime;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("AutoFadeOut")]
		protected bool _autoFadeOut;

		protected global::ScheduleOne.Audio.AudioSourceController _audioSource;

		protected float _fadeVolumeMultiplier;

		public bool IsPlaying { get; private set; }

		public string TrackName => null;

		public int Priority => 0;

		protected virtual void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public virtual void Play()
		{
		}

		public virtual void Stop()
		{
		}

		protected virtual void Update()
		{
		}
	}
}
