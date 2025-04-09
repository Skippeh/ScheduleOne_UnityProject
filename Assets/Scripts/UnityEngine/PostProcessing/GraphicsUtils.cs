namespace UnityEngine.PostProcessing
{
	public static class GraphicsUtils
	{
		private static Texture2D s_WhiteTexture;

		private static Mesh s_Quad;

		public static bool isLinearColorSpace => false;

		public static bool supportsDX11 => false;

		public static Texture2D whiteTexture => null;

		public static Mesh quad => null;

		public static void Blit(Material material, int pass)
		{
		}

		public static void ClearAndBlit(Texture source, RenderTexture destination, Material material, int pass, bool clearColor = true, bool clearDepth = false)
		{
		}

		public static void Destroy(Object obj)
		{
		}

		public static void Dispose()
		{
		}
	}
}
