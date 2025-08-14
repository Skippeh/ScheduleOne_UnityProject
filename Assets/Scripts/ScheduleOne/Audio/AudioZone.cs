namespace ScheduleOne.Audio
{
	public class AudioZone : global::ScheduleOne.Audio.Zone
	{
		[global::System.Serializable]
		public class Track
		{
			public global::ScheduleOne.Audio.AudioSourceController Source;

			[global::UnityEngine.Range(0.01f, 2f)]
			public float Volume;

			public int StartTime;

			public int EndTime;

			public int FadeTime;

			private float timeVolMultiplier;

			private int fadeInStart;

			private int fadeInEnd;

			private int fadeOutStart;

			private int fadeOutEnd;

			private int fadeInStartMinSum;

			private int fadeInEndMinSum;

			private int fadeOutStartMinSum;

			private int fadeOutEndMinSum;

			public void Init()
			{
			}

			public void Update(float multiplier)
			{
			}

			public void UpdateTimeMultiplier(int time)
			{
			}
		}

		public const float VOLUME_CHANGE_RATE = 1f;

		public const float ROLLOFF_SCALE = 0.5f;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.Range(1f, 200f)]
		public float MaxDistance;

		public global::System.Collections.Generic.List<global::ScheduleOne.Audio.AudioZone.Track> Tracks;

		public global::System.Collections.Generic.Dictionary<global::ScheduleOne.Audio.AudioZoneModifierVolume, float> Modifiers;

		protected float CurrentVolumeMultiplier;

		public float LocalPlayerDistance { get; protected set; }

		public float VolumeModifier { get; set; }

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		public void Recalculate()
		{
		}

		private void Update()
		{
		}

		private float GetTotalVolumeMultiplier()
		{
			return 0f;
		}

		private void MinPass()
		{
		}

		public void AddModifier(global::ScheduleOne.Audio.AudioZoneModifierVolume modifier, float value)
		{
		}

		public void RemoveModifier(global::ScheduleOne.Audio.AudioZoneModifierVolume modifier)
		{
		}

		private float GetFalloffFactor(float distance)
		{
			return 0f;
		}
	}
}
