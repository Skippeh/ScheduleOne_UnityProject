namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Audio.AudioSourceController))]
	public class AmbientOneShot : global::UnityEngine.MonoBehaviour
	{
		private enum EPlayTime
		{
			All = 0,
			Day = 1,
			Night = 2
		}

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("Volume")]
		[global::UnityEngine.Range(0f, 1f)]
		private float _volume;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("ChancePerHour")]
		[global::UnityEngine.Range(0f, 1f)]
		private float _playChancePerHour;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("CooldownTime")]
		private int _cooldownTime;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("PlayTime")]
		private global::ScheduleOne.Audio.AmbientOneShot.EPlayTime _playTime;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("MinDistance")]
		private float _minDistanceFromCameraToPlay;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("MaxDistance")]
		private float _maxDistanceFromCameraToPlay;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("PlayWhileInSewer")]
		private bool _canPlayWhilePlayerInSewer;

		private int _timeSinceLastPlay;

		private global::ScheduleOne.Audio.AudioSourceController _audioSource;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnUncappedMinPass()
		{
		}

		private void Play()
		{
		}
	}
}
