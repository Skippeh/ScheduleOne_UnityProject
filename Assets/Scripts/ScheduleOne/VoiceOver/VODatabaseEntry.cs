using System;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	[Serializable]
	public class VODatabaseEntry
	{
		public EVOLineType LineType;

		public AudioClip[] Clips;

		private AudioClip lastClip;

		public float VolumeMultiplier;

		public AudioClip GetRandomClip()
		{
			return null;
		}
	}
}
