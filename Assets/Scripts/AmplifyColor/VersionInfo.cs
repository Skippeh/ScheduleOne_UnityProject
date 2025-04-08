namespace AmplifyColor
{
	[global::System.Serializable]
	public class VersionInfo
	{
		public const byte Major = 1;

		public const byte Minor = 9;

		public const byte Release = 0;

		private static string StageSuffix;

		private static string TrialSuffix;

		[global::UnityEngine.SerializeField]
		private int m_major;

		[global::UnityEngine.SerializeField]
		private int m_minor;

		[global::UnityEngine.SerializeField]
		private int m_release;

		public static int FullNumber => 0;

		public int Number => 0;

		public static string StaticToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private VersionInfo()
		{
		}

		private VersionInfo(byte major, byte minor, byte release)
		{
		}

		public static global::AmplifyColor.VersionInfo Current()
		{
			return null;
		}

		public static bool Matches(global::AmplifyColor.VersionInfo version)
		{
			return false;
		}
	}
}
