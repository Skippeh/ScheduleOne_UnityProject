namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Audio.AudioSourceController))]
	public class AudioClipListPlayer : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("Clips")]
		private global::System.Collections.Generic.List<global::UnityEngine.AudioClip> _clips;

		[global::UnityEngine.SerializeField]
		private bool _shuffleOnAwake;

		private global::ScheduleOne.Audio.AudioSourceController _audioSource;

		private int _currentClipIndex;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnTick()
		{
		}
	}
}
