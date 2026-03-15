namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Audio.AudioSourceController))]
	public class TimeOfDayVolumeController : global::UnityEngine.MonoBehaviour
	{
		private const float MinVolume = 0.3f;

		private const float FadeSpeed = 0.25f;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("VolumeCurve")]
		private global::UnityEngine.AnimationCurve _timeOfDayVolumeCurve;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("FadeDuringMusic")]
		private bool _reduceVolumeWhenSoundtrackPlaying;

		private global::ScheduleOne.Audio.AudioSourceController _audioSourceController;

		private float _volumeMultiplier;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
