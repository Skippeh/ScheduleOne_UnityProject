using System.Collections.Generic;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Audio
{
	public class AmbientTrack : MonoBehaviour
	{
		public const float MIN_TIME_BETWEEN_AMBIENT_TRACKS = 540f;

		public static AmbientTrack LastPlayedTrack;

		public static bool TrackQueued;

		public List<MusicTrack> Tracks;

		public int MinTime;

		public int MaxTime;

		public float Chance;

		private int startTime;

		private bool playTrack;

		private bool trackRandomized;

		private void Awake()
		{
		}

		[Button]
		public void ForcePlay()
		{
		}

		public void Stop()
		{
		}

		private void Update()
		{
		}
	}
}
