namespace UnityEngine.PostProcessing
{
	public sealed class RenderTextureFactory : global::System.IDisposable
	{
		private global::System.Collections.Generic.HashSet<global::UnityEngine.RenderTexture> m_TemporaryRTs;

		public global::UnityEngine.RenderTexture Get(global::UnityEngine.RenderTexture baseRenderTexture)
		{
			return null;
		}

		public global::UnityEngine.RenderTexture Get(int width, int height, int depthBuffer = 0, global::UnityEngine.RenderTextureFormat format = global::UnityEngine.RenderTextureFormat.ARGBHalf, global::UnityEngine.RenderTextureReadWrite rw = global::UnityEngine.RenderTextureReadWrite.Default, global::UnityEngine.FilterMode filterMode = global::UnityEngine.FilterMode.Bilinear, global::UnityEngine.TextureWrapMode wrapMode = global::UnityEngine.TextureWrapMode.Clamp, string name = "FactoryTempTexture")
		{
			return null;
		}

		public void Release(global::UnityEngine.RenderTexture rt)
		{
		}

		public void ReleaseAll()
		{
		}

		public void Dispose()
		{
		}
	}
}
