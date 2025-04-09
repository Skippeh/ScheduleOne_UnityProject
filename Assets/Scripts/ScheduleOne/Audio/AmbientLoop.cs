using UnityEngine;

namespace ScheduleOne.Audio
{
	[RequireComponent(typeof(AudioSourceController))]
	public class AmbientLoop : MonoBehaviour
	{
		public const float MUSIC_FADE_MULTIPLIER = 0.3f;

		public const float MUSIC_FADE_TIME = 4f;

		public AnimationCurve VolumeCurve;

		public bool FadeDuringMusic;

		private AudioSourceController audioSourceController;

		private float musicScale;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
