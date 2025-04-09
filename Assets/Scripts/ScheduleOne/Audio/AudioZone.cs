using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Audio
{
	public class AudioZone : Zone
	{
		[Serializable]
		public class Track
		{
			public AudioSourceController Source;

			[Range(0.01f, 2f)]
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

		[Header("Settings")]
		[Range(1f, 200f)]
		public float MaxDistance;

		public List<Track> Tracks;

		public Dictionary<AudioZoneModifierVolume, float> Modifiers;

		protected float CurrentVolumeMultiplier;

		public float VolumeModifier { get; set; }

		private void Start()
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

		public void AddModifier(AudioZoneModifierVolume modifier, float value)
		{
		}

		public void RemoveModifier(AudioZoneModifierVolume modifier)
		{
		}

		private float GetFalloffFactor(float distance)
		{
			return 0f;
		}
	}
}
