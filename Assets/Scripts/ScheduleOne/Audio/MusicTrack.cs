using UnityEngine;

namespace ScheduleOne.Audio
{
	[RequireComponent(typeof(AudioSourceController))]
	public class MusicTrack : MonoBehaviour
	{
		public bool Enabled;

		public string TrackName;

		public int Priority;

		public float FadeInTime;

		public float FadeOutTime;

		public AudioSourceController Controller;

		public float VolumeMultiplier;

		public bool AutoFadeOut;

		protected float volumeMultiplier;

		public bool IsPlaying { get; private set; }

		private void OnValidate()
		{
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		protected virtual void Awake()
		{
		}

		public virtual void Update()
		{
		}

		public virtual void Play()
		{
		}

		public virtual void Stop()
		{
		}
	}
}
