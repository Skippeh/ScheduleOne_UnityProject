namespace ScheduleOne.Audio
{
	public class MusicPlayer : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.Audio.MusicPlayer>
	{
		public static float TimeSinceLastAmbientTrack;

		public global::System.Collections.Generic.List<global::ScheduleOne.Audio.MusicTrack> Tracks;

		public global::UnityEngine.Audio.AudioMixerGroup MusicMixer;

		public global::UnityEngine.Audio.AudioMixerSnapshot DefaultSnapshot;

		public global::UnityEngine.Audio.AudioMixerSnapshot DistortedSnapshot;

		private global::ScheduleOne.Audio.MusicTrack _currentTrack;

		public bool IsPlaying => false;

		public void OnValidate()
		{
		}

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		public void SetMusicDistorted(bool distorted, float transition = 5f)
		{
		}

		public void SetTrackEnabled(string trackName, bool enabled)
		{
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
