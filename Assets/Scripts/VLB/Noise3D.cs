using UnityEngine;

namespace VLB
{
	public static class Noise3D
	{
		private static bool ms_IsSupportedChecked;

		private static bool ms_IsSupported;

		private static Texture3D ms_NoiseTexture;

		private const int kMinShaderLevel = 35;

		public static bool isSupported => false;

		public static bool isProperlyLoaded => false;

		public static string isNotSupportedString => null;

		[RuntimeInitializeOnLoadMethod]
		private static void OnStartUp()
		{
		}

		public static void LoadIfNeeded()
		{
		}
	}
}
