using System;
using System.Collections.Generic;

namespace UnityEngine.PostProcessing
{
	public sealed class RenderTextureFactory : IDisposable
	{
		private HashSet<RenderTexture> m_TemporaryRTs;

		public RenderTexture Get(RenderTexture baseRenderTexture)
		{
			return null;
		}

		public RenderTexture Get(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite rw = RenderTextureReadWrite.Default, FilterMode filterMode = FilterMode.Bilinear, TextureWrapMode wrapMode = TextureWrapMode.Clamp, string name = "FactoryTempTexture")
		{
			return null;
		}

		public void Release(RenderTexture rt)
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
