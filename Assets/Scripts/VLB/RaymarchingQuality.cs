namespace VLB
{
	[global::System.Serializable]
	public class RaymarchingQuality
	{
		public string name;

		public int stepCount;

		[global::UnityEngine.SerializeField]
		private int _UniqueID;

		private static global::VLB.RaymarchingQuality ms_DefaultInstance;

		private const int kRandomUniqueIdMinRange = 4;

		public int uniqueID => 0;

		public bool hasValidUniqueID => false;

		public static global::VLB.RaymarchingQuality defaultInstance => null;

		private RaymarchingQuality(int uniqueID)
		{
		}

		public static global::VLB.RaymarchingQuality New()
		{
			return null;
		}

		public static global::VLB.RaymarchingQuality New(string name, int forcedUniqueID, int stepCount)
		{
			return null;
		}

		private static bool HasRaymarchingQualityWithSameUniqueID(global::VLB.RaymarchingQuality[] values, int id)
		{
			return false;
		}
	}
}
