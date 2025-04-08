namespace UnityEngine.PostProcessing
{
	public sealed class FogComponent : global::UnityEngine.PostProcessing.PostProcessingComponentCommandBuffer<global::UnityEngine.PostProcessing.FogModel>
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

		public override global::UnityEngine.DepthTextureMode GetCameraFlags()
		{
			return default(global::UnityEngine.DepthTextureMode);
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
