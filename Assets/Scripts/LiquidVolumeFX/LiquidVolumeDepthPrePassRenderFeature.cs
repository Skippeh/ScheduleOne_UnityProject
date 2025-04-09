using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace LiquidVolumeFX
{
	public class LiquidVolumeDepthPrePassRenderFeature : ScriptableRendererFeature
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

		private class DepthPass : ScriptableRenderPass
		{
			private class PassData
			{
				public Camera cam;

				public CommandBuffer cmd;

				public DepthPass depthPass;

				public Material mat;

				public RTHandle source;

				public RTHandle depth;

				public RenderTextureDescriptor cameraTargetDescriptor;
			}

			private const string profilerTag = "LiquidVolumeDepthPrePass";

			private Material mat;

			private int targetNameId;

			private RTHandle targetRT;

			private int passId;

			private List<LiquidVolume> lvRenderers;

			public ScriptableRenderer renderer;

			public bool interleavedRendering;

			private static Vector3 currentCameraPosition;

			private readonly PassData passData;

			public DepthPass(Material mat, Pass pass, RenderPassEvent renderPassEvent)
			{
			}

			public void Setup(LiquidVolumeDepthPrePassRenderFeature feature, ScriptableRenderer renderer)
			{
			}

			private int SortByDistanceToCamera(LiquidVolume lv1, LiquidVolume lv2)
			{
				return 0;
			}

			public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
			}

			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}

			private static void ExecutePass(PassData passData)
			{
			}

			public void CleanUp()
			{
			}
		}

		public static readonly List<LiquidVolume> lvBackRenderers;

		public static readonly List<LiquidVolume> lvFrontRenderers;

		[SerializeField]
		[HideInInspector]
		private Shader shader;

		public static bool installed;

		private Material mat;

		private DepthPass backPass;

		private DepthPass frontPass;

		[Tooltip("Renders each irregular liquid volume completely before rendering the next one.")]
		public bool interleavedRendering;

		public RenderPassEvent renderPassEvent;

		public static void AddLiquidToBackRenderers(LiquidVolume lv)
		{
		}

		public static void RemoveLiquidFromBackRenderers(LiquidVolume lv)
		{
		}

		public static void AddLiquidToFrontRenderers(LiquidVolume lv)
		{
		}

		public static void RemoveLiquidFromFrontRenderers(LiquidVolume lv)
		{
		}

		private void OnDestroy()
		{
		}

		public override void Create()
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}
	}
}
