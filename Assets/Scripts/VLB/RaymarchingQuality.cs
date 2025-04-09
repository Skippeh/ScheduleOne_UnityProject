using System;
using UnityEngine;

namespace VLB
{
	[Serializable]
	public class RaymarchingQuality
	{
		public string name;

		public int stepCount;

		[SerializeField]
		private int _UniqueID;

		private static RaymarchingQuality ms_DefaultInstance;

		private const int kRandomUniqueIdMinRange = 4;

		public int uniqueID => 0;

		public bool hasValidUniqueID => false;

		public static RaymarchingQuality defaultInstance => null;

		private RaymarchingQuality(int uniqueID)
		{
		}

		public static RaymarchingQuality New()
		{
			return null;
		}

		public static RaymarchingQuality New(string name, int forcedUniqueID, int stepCount)
		{
			return null;
		}

		private static bool HasRaymarchingQualityWithSameUniqueID(RaymarchingQuality[] values, int id)
		{
			return false;
		}
	}
}
