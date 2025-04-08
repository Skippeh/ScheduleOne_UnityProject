namespace UnityEngine.PostProcessing
{
	public static class GraphicsUtils
	{
		private static global::UnityEngine.Texture2D s_WhiteTexture;

		private static global::UnityEngine.Mesh s_Quad;

		public static bool isLinearColorSpace => false;

		public static bool supportsDX11 => false;

		public static global::UnityEngine.Texture2D whiteTexture => null;

		public static global::UnityEngine.Mesh quad => null;

		public static void Blit(global::UnityEngine.Material material, int pass)
		{
		}

		public static void ClearAndBlit(global::UnityEngine.Texture source, global::UnityEngine.RenderTexture destination, global::UnityEngine.Material material, int pass, bool clearColor = true, bool clearDepth = false)
		{
		}

		public static void Destroy(global::UnityEngine.Object obj)
		{
		}

		public static void Dispose()
		{
		}
	}
}
