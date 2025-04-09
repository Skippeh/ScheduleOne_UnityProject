using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	[Serializable]
	[CreateAssetMenu(fileName = "VODatabase", menuName = "ScriptableObjects/VODatabase")]
	public class VODatabase : ScriptableObject
	{
		[Range(0f, 2f)]
		public float VolumeMultiplier;

		public List<VODatabaseEntry> Entries;

		public VODatabaseEntry GetEntry(EVOLineType lineType)
		{
			return null;
		}

		public AudioClip GetRandomClip(EVOLineType lineType)
		{
			return null;
		}
	}
}
