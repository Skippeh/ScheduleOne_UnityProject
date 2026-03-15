namespace ScheduleOne.Audio
{
	public class AmbientTrackGroup : global::UnityEngine.MonoBehaviour
	{
		private const float AmbientTrackCooldown = 540f;

		private static float TimeOnLastAmbientTrackStart;

		private static global::ScheduleOne.Audio.AmbientTrackGroup LastPlayedTrackGroup;

		private static bool IsAnyTrackGroupQueued;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("Tracks")]
		private global::System.Collections.Generic.List<global::ScheduleOne.Audio.MusicTrack> _trackList;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("MinTime")]
		private int _windowStartTime;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("MaxTime")]
		private int _windowEndTime;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("Chance")]
		[global::UnityEngine.Range(0f, 1f)]
		private float _chanceToPlay;

		private int _startTime;

		private bool _playTrack;

		private bool _trackRandomized;

		private void Awake()
		{
		}

		[global::ScheduleOne.Core.Button]
		public void ForcePlay()
		{
		}

		public void Stop()
		{
		}

		private void Update()
		{
		}

		protected virtual bool CanPlayNow()
		{
			return false;
		}
	}
}
