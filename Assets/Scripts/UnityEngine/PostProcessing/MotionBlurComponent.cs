namespace UnityEngine.PostProcessing
{
	public sealed class MotionBlurComponent : global::UnityEngine.PostProcessing.PostProcessingComponentCommandBuffer<global::UnityEngine.PostProcessing.MotionBlurModel>
	{
		private static class Uniforms
		{
			internal static readonly int _VelocityScale;

			internal static readonly int _MaxBlurRadius;

			internal static readonly int _RcpMaxBlurRadius;

			internal static readonly int _VelocityTex;

			internal static readonly int _MainTex;

			internal static readonly int _Tile2RT;

			internal static readonly int _Tile4RT;

			internal static readonly int _Tile8RT;

			internal static readonly int _TileMaxOffs;

			internal static readonly int _TileMaxLoop;

			internal static readonly int _TileVRT;

			internal static readonly int _NeighborMaxTex;

			internal static readonly int _LoopCount;

			internal static readonly int _TempRT;

			internal static readonly int _History1LumaTex;

			internal static readonly int _History2LumaTex;

			internal static readonly int _History3LumaTex;

			internal static readonly int _History4LumaTex;

			internal static readonly int _History1ChromaTex;

			internal static readonly int _History2ChromaTex;

			internal static readonly int _History3ChromaTex;

			internal static readonly int _History4ChromaTex;

			internal static readonly int _History1Weight;

			internal static readonly int _History2Weight;

			internal static readonly int _History3Weight;

			internal static readonly int _History4Weight;
		}

		private enum Pass
		{
			VelocitySetup = 0,
			TileMax1 = 1,
			TileMax2 = 2,
			TileMaxV = 3,
			NeighborMax = 4,
			Reconstruction = 5,
			FrameCompression = 6,
			FrameBlendingChroma = 7,
			FrameBlendingRaw = 8
		}

		public class ReconstructionFilter
		{
			private global::UnityEngine.RenderTextureFormat m_VectorRTFormat;

			private global::UnityEngine.RenderTextureFormat m_PackedRTFormat;

			private void CheckTextureFormatSupport()
			{
			}

			public bool IsSupported()
			{
				return false;
			}

			public void ProcessImage(global::UnityEngine.PostProcessing.PostProcessingContext context, global::UnityEngine.Rendering.CommandBuffer cb, ref global::UnityEngine.PostProcessing.MotionBlurModel.Settings settings, global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier destination, global::UnityEngine.Material material)
			{
			}
		}

		public class FrameBlendingFilter
		{
			private struct Frame
			{
				public global::UnityEngine.RenderTexture lumaTexture;

				public global::UnityEngine.RenderTexture chromaTexture;

				private float m_Time;

				private global::UnityEngine.Rendering.RenderTargetIdentifier[] m_MRT;

				public float CalculateWeight(float strength, float currentTime)
				{
					return 0f;
				}

				public void Release()
				{
				}

				public void MakeRecord(global::UnityEngine.Rendering.CommandBuffer cb, global::UnityEngine.Rendering.RenderTargetIdentifier source, int width, int height, global::UnityEngine.Material material)
				{
				}

				public void MakeRecordRaw(global::UnityEngine.Rendering.CommandBuffer cb, global::UnityEngine.Rendering.RenderTargetIdentifier source, int width, int height, global::UnityEngine.RenderTextureFormat format)
				{
				}
			}

			private bool m_UseCompression;

			private global::UnityEngine.RenderTextureFormat m_RawTextureFormat;

			private global::UnityEngine.PostProcessing.MotionBlurComponent.FrameBlendingFilter.Frame[] m_FrameList;

			private int m_LastFrameCount;

			public void Dispose()
			{
			}

			public void PushFrame(global::UnityEngine.Rendering.CommandBuffer cb, global::UnityEngine.Rendering.RenderTargetIdentifier source, int width, int height, global::UnityEngine.Material material)
			{
			}

			public void BlendFrames(global::UnityEngine.Rendering.CommandBuffer cb, float strength, global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier destination, global::UnityEngine.Material material)
			{
			}

			private static bool CheckSupportCompression()
			{
				return false;
			}

			private static global::UnityEngine.RenderTextureFormat GetPreferredRenderTextureFormat()
			{
				return default(global::UnityEngine.RenderTextureFormat);
			}

			private global::UnityEngine.PostProcessing.MotionBlurComponent.FrameBlendingFilter.Frame GetFrameRelative(int offset)
			{
				return default(global::UnityEngine.PostProcessing.MotionBlurComponent.FrameBlendingFilter.Frame);
			}
		}

		private global::UnityEngine.PostProcessing.MotionBlurComponent.ReconstructionFilter m_ReconstructionFilter;

		private global::UnityEngine.PostProcessing.MotionBlurComponent.FrameBlendingFilter m_FrameBlendingFilter;

		private bool m_FirstFrame;

		public global::UnityEngine.PostProcessing.MotionBlurComponent.ReconstructionFilter reconstructionFilter => null;

		public global::UnityEngine.PostProcessing.MotionBlurComponent.FrameBlendingFilter frameBlendingFilter => null;

		public override bool active => false;

		public override string GetName()
		{
			return null;
		}

		public void ResetHistory()
		{
		}

		public override global::UnityEngine.DepthTextureMode GetCameraFlags()
		{
			return default(global::UnityEngine.DepthTextureMode);
		}

		public override global::UnityEngine.Rendering.CameraEvent GetCameraEvent()
		{
			return default(global::UnityEngine.Rendering.CameraEvent);
		}

		public override void OnEnable()
		{
		}

		public override void PopulateCommandBuffer(global::UnityEngine.Rendering.CommandBuffer cb)
		{
		}

		public override void OnDisable()
		{
		}
	}
}
