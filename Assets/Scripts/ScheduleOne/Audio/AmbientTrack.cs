namespace ScheduleOne.Audio
{
	public class AmbientTrack : global::UnityEngine.MonoBehaviour
	{
		public const float MIN_TIME_BETWEEN_AMBIENT_TRACKS = 540f;

		public static global::ScheduleOne.Audio.AmbientTrack LastPlayedTrack;

		public static bool TrackQueued;

		public global::System.Collections.Generic.List<global::ScheduleOne.Audio.MusicTrack> Tracks;

		public int MinTime;

		public int MaxTime;

		public float Chance;

		private int startTime;

		private bool playTrack;

		private bool trackRandomized;

		private void Awake()
		{
		}

		[global::EasyButtons.Button]
		public void ForcePlay()
		{
		}

		public void Stop()
		{
		}

		private void Update()
		{
		}

		protected virtual bool CanStartAmbientTrack()
		{
			return false;
		}
	}
}
