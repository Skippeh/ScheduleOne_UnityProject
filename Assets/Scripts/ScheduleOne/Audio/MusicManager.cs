namespace ScheduleOne.Audio
{
	public class MusicManager : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.Audio.MusicManager>
	{
		private const float TrackUpdateInterval = 0.2f;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("DefaultSnapshot")]
		private global::UnityEngine.Audio.AudioMixerSnapshot _defaultSnapshot;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("DistortedSnapshot")]
		private global::UnityEngine.Audio.AudioMixerSnapshot _distortedSnapshot;

		private global::System.Collections.Generic.List<global::ScheduleOne.Audio.MusicTrack> _tracks;

		private global::ScheduleOne.Audio.MusicTrack _currentTrack;

		public bool IsAnyTrackPlaying => false;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void SetMusicDistorted(bool distorted, float transition = 5f)
		{
		}

		public void SetTrackEnabled(string trackName, bool enabled)
		{
		}

		public bool TryGetTrack(string trackName, out global::ScheduleOne.Audio.MusicTrack track)
		{
			track = null;
			return false;
		}

		public void StopTrack(string trackName)
		{
		}

		public void StopAndDisableTracks()
		{
		}

		private void UpdateTracks()
		{
		}
	}
}
