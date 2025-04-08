namespace UnityEngine.PostProcessing
{
	public sealed class AmbientOcclusionComponent : global::UnityEngine.PostProcessing.PostProcessingComponentCommandBuffer<global::UnityEngine.PostProcessing.AmbientOcclusionModel>
	{
		private static class Uniforms
		{
			internal static readonly int _Intensity;

			internal static readonly int _Radius;

			internal static readonly int _FogParams;

			internal static readonly int _Downsample;

			internal static readonly int _SampleCount;

			internal static readonly int _OcclusionTexture1;

			internal static readonly int _OcclusionTexture2;

			internal static readonly int _OcclusionTexture;

			internal static readonly int _MainTex;

			internal static readonly int _TempRT;
		}

		private enum OcclusionSource
		{
			DepthTexture = 0,
			DepthNormalsTexture = 1,
			GBuffer = 2
		}

		private const string k_BlitShaderString = "Hidden/Post FX/Blit";

		private const string k_ShaderString = "Hidden/Post FX/Ambient Occlusion";

		private readonly global::UnityEngine.Rendering.RenderTargetIdentifier[] m_MRT;

		private global::UnityEngine.PostProcessing.AmbientOcclusionComponent.OcclusionSource occlusionSource => default(global::UnityEngine.PostProcessing.AmbientOcclusionComponent.OcclusionSource);

		private bool ambientOnlySupported => false;

		public override bool active => false;

		public override global::UnityEngine.DepthTextureMode GetCameraFlags()
		{
			return default(global::UnityEngine.DepthTextureMode);
		}

		public override string GetName()
		{
			return null;
		}

		public override global::UnityEngine.Rendering.CameraEvent GetCameraEvent()
		{
			return default(global::UnityEngine.Rendering.CameraEvent);
		}

		public override void PopulateCommandBuffer(global::UnityEngine.Rendering.CommandBuffer cb)
		{
		}
	}
}
