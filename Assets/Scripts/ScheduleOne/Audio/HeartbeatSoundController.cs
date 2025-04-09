using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Audio
{
	public class HeartbeatSoundController : MonoBehaviour
	{
		public AudioSourceController sound;

		public FloatSmoother VolumeController;

		public FloatSmoother PitchController;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
