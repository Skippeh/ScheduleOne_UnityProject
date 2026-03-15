namespace ScheduleOne.Audio
{
	public class AudioZone : global::ScheduleOne.Audio.PolygonalZone
	{
		private const float VolumeChangeRate = 1f;

		private const float UpdateInterval = 0.25f;

		[global::UnityEngine.Range(1f, 200f)]
		[global::UnityEngine.Serialization.FormerlySerializedAs("MaxDistance")]
		[global::UnityEngine.SerializeField]
		private float _maximumAudibleDistance;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("Tracks")]
		private global::System.Collections.Generic.List<global::ScheduleOne.Audio.AudioZoneTrack> _tracks;

		private float _localCameraDistance;

		private float _currentVolume;

		private global::System.Collections.Generic.List<global::ScheduleOne.Audio.IAudioZoneModifier> _modifiers;

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnUncappedMinPass()
		{
		}

		private void Update()
		{
		}

		private float GetModifierMultiplier()
		{
			return 0f;
		}

		private void RecalculateCameraDistance()
		{
		}

		public void AddModifier(global::ScheduleOne.Audio.IAudioZoneModifier modifier)
		{
		}

		public void RemoveModifier(global::ScheduleOne.Audio.IAudioZoneModifier modifier)
		{
		}

		private float GetFalloffFactor(float distance)
		{
			return 0f;
		}
	}
}
