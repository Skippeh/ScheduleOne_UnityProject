namespace UnityEngine.PostProcessing
{
	public sealed class BloomComponent : global::UnityEngine.PostProcessing.PostProcessingComponentRenderTexture<global::UnityEngine.PostProcessing.BloomModel>
	{
		private static class Uniforms
		{
			internal static readonly int _AutoExposure;

			internal static readonly int _Threshold;

			internal static readonly int _Curve;

			internal static readonly int _PrefilterOffs;

			internal static readonly int _SampleScale;

			internal static readonly int _BaseTex;

			internal static readonly int _BloomTex;

			internal static readonly int _Bloom_Settings;

			internal static readonly int _Bloom_DirtTex;

			internal static readonly int _Bloom_DirtIntensity;
		}

		private const int k_MaxPyramidBlurLevel = 16;

		private readonly global::UnityEngine.RenderTexture[] m_BlurBuffer1;

		private readonly global::UnityEngine.RenderTexture[] m_BlurBuffer2;

		public override bool active => false;

		public void Prepare(global::UnityEngine.RenderTexture source, global::UnityEngine.Material uberMaterial, global::UnityEngine.Texture autoExposure)
		{
		}
	}
}
