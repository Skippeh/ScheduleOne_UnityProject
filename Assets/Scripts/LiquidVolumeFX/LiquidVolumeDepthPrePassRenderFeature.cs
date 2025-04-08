namespace LiquidVolumeFX
{
	public class LiquidVolumeDepthPrePassRenderFeature : global::UnityEngine.Rendering.Universal.ScriptableRendererFeature
	{
		private static class ShaderParams
		{
			public const string RTBackBufferName = "_VLBackBufferTexture";

			public static int RTBackBuffer;

			public const string RTFrontBufferName = "_VLFrontBufferTexture";

			public static int RTFrontBuffer;

			public static int FlaskThickness;

			public static int ForcedInvisible;

			public const string SKW_FP_RENDER_TEXTURE = "LIQUID_VOLUME_FP_RENDER_TEXTURES";
		}

		private enum Pass
		{
			BackBuffer = 0,
			FrontBuffer = 1
		}

		private class DepthPass : global::UnityEngine.Rendering.Universal.ScriptableRenderPass
		{
			private class PassData
			{
				public global::UnityEngine.Camera cam;

				public global::UnityEngine.Rendering.CommandBuffer cmd;

				public global::LiquidVolumeFX.LiquidVolumeDepthPrePassRenderFeature.DepthPass depthPass;

				public global::UnityEngine.Material mat;

				public global::UnityEngine.Rendering.RTHandle source;

				public global::UnityEngine.Rendering.RTHandle depth;

				public global::UnityEngine.RenderTextureDescriptor cameraTargetDescriptor;
			}

			private const string profilerTag = "LiquidVolumeDepthPrePass";

			private global::UnityEngine.Material mat;

			private int targetNameId;

			private global::UnityEngine.Rendering.RTHandle targetRT;

			private int passId;

			private global::System.Collections.Generic.List<global::LiquidVolumeFX.LiquidVolume> lvRenderers;

			public global::UnityEngine.Rendering.Universal.ScriptableRenderer renderer;

			public bool interleavedRendering;

			private static global::UnityEngine.Vector3 currentCameraPosition;

			private readonly global::LiquidVolumeFX.LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData passData;

			public DepthPass(global::UnityEngine.Material mat, global::LiquidVolumeFX.LiquidVolumeDepthPrePassRenderFeature.Pass pass, global::UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent)
			{
			}

			public void Setup(global::LiquidVolumeFX.LiquidVolumeDepthPrePassRenderFeature feature, global::UnityEngine.Rendering.Universal.ScriptableRenderer renderer)
			{
			}

			private int SortByDistanceToCamera(global::LiquidVolumeFX.LiquidVolume lv1, global::LiquidVolumeFX.LiquidVolume lv2)
			{
				return 0;
			}

			public override void Configure(global::UnityEngine.Rendering.CommandBuffer cmd, global::UnityEngine.RenderTextureDescriptor cameraTextureDescriptor)
			{
			}

			public override void Execute(global::UnityEngine.Rendering.ScriptableRenderContext context, ref global::UnityEngine.Rendering.Universal.RenderingData renderingData)
			{
			}

			private static void ExecutePass(global::LiquidVolumeFX.LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData passData)
			{
			}

			public void CleanUp()
			{
			}
		}

		public static readonly global::System.Collections.Generic.List<global::LiquidVolumeFX.LiquidVolume> lvBackRenderers;

		public static readonly global::System.Collections.Generic.List<global::LiquidVolumeFX.LiquidVolume> lvFrontRenderers;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.HideInInspector]
		private global::UnityEngine.Shader shader;

		public static bool installed;

		private global::UnityEngine.Material mat;

		private global::LiquidVolumeFX.LiquidVolumeDepthPrePassRenderFeature.DepthPass backPass;

		private global::LiquidVolumeFX.LiquidVolumeDepthPrePassRenderFeature.DepthPass frontPass;

		[global::UnityEngine.Tooltip("Renders each irregular liquid volume completely before rendering the next one.")]
		public bool interleavedRendering;

		public global::UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent;

		public static void AddLiquidToBackRenderers(global::LiquidVolumeFX.LiquidVolume lv)
		{
		}

		public static void RemoveLiquidFromBackRenderers(global::LiquidVolumeFX.LiquidVolume lv)
		{
		}

		public static void AddLiquidToFrontRenderers(global::LiquidVolumeFX.LiquidVolume lv)
		{
		}

		public static void RemoveLiquidFromFrontRenderers(global::LiquidVolumeFX.LiquidVolume lv)
		{
		}

		private void OnDestroy()
		{
		}

		public override void Create()
		{
		}

		public override void AddRenderPasses(global::UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref global::UnityEngine.Rendering.Universal.RenderingData renderingData)
		{
		}
	}
}
