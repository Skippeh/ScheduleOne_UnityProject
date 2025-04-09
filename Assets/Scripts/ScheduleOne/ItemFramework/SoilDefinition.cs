using System;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	[Serializable]
	[CreateAssetMenu(fileName = "SoilDefinition", menuName = "ScriptableObjects/Item Definitions/SoilDefinition", order = 1)]
	public class SoilDefinition : StorableItemDefinition
	{
		public enum ESoilQuality
		{
			Basic = 0,
			Premium = 1
		}

		public ESoilQuality SoilQuality;

		public Material DrySoilMat;

		public Material WetSoilMat;

		public Color ParticleColor;

		public int Uses;
	}
}
