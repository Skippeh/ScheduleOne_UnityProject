namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Audio.AudioSourceController))]
	public class AmbientLoop : global::UnityEngine.MonoBehaviour
	{
		public const float MUSIC_FADE_MULTIPLIER = 0.3f;

		public global::UnityEngine.AnimationCurve VolumeCurve;

		public bool FadeDuringMusic;

		private global::ScheduleOne.Audio.AudioSourceController audioSourceController;

		private float musicScale;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
