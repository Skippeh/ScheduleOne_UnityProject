using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	public sealed class FogComponent : PostProcessingComponentCommandBuffer<FogModel>
	{
		private static class Uniforms
		{
			internal static readonly int _FogColor;

			internal static readonly int _Density;

			internal static readonly int _Start;

			internal static readonly int _End;

			internal static readonly int _TempRT;
		}

		private const string k_ShaderString = "Hidden/Post FX/Fog";

		public override bool active => false;

		public override string GetName()
		{
			return null;
		}

		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		public override CameraEvent GetCameraEvent()
		{
			return default(CameraEvent);
		}

		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}
	}
}
