namespace UnityEngine.PostProcessing
{
	public sealed class EyeAdaptationComponent : global::UnityEngine.PostProcessing.PostProcessingComponentRenderTexture<global::UnityEngine.PostProcessing.EyeAdaptationModel>
	{
		private static class Uniforms
		{
			internal static readonly int _Params;

			internal static readonly int _Speed;

			internal static readonly int _ScaleOffsetRes;

			internal static readonly int _ExposureCompensation;

			internal static readonly int _AutoExposure;

			internal static readonly int _DebugWidth;
		}

		private global::UnityEngine.ComputeShader m_EyeCompute;

		private global::UnityEngine.ComputeBuffer m_HistogramBuffer;

		private readonly global::UnityEngine.RenderTexture[] m_AutoExposurePool;

		private int m_AutoExposurePingPing;

		private global::UnityEngine.RenderTexture m_CurrentAutoExposure;

		private global::UnityEngine.RenderTexture m_DebugHistogram;

		private static uint[] s_EmptyHistogramBuffer;

		private bool m_FirstFrame;

		private const int k_HistogramBins = 64;

		private const int k_HistogramThreadX = 16;

		private const int k_HistogramThreadY = 16;

		public override bool active => false;

		public void ResetHistory()
		{
		}

		public override void OnEnable()
		{
		}

		public override void OnDisable()
		{
		}

		private global::UnityEngine.Vector4 GetHistogramScaleOffsetRes()
		{
			return default(global::UnityEngine.Vector4);
		}

		public global::UnityEngine.Texture Prepare(global::UnityEngine.RenderTexture source, global::UnityEngine.Material uberMaterial)
		{
			return null;
		}

		public void OnGUI()
		{
		}
	}
}
