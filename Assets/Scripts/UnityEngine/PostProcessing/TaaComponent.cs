namespace UnityEngine.PostProcessing
{
	public sealed class TaaComponent : global::UnityEngine.PostProcessing.PostProcessingComponentRenderTexture<global::UnityEngine.PostProcessing.AntialiasingModel>
	{
		private static class Uniforms
		{
			internal static int _Jitter;

			internal static int _SharpenParameters;

			internal static int _FinalBlendParameters;

			internal static int _HistoryTex;

			internal static int _MainTex;
		}

		private const string k_ShaderString = "Hidden/Post FX/Temporal Anti-aliasing";

		private const int k_SampleCount = 8;

		private readonly global::UnityEngine.RenderBuffer[] m_MRT;

		private int m_SampleIndex;

		private bool m_ResetHistory;

		private global::UnityEngine.RenderTexture m_HistoryTexture;

		public override bool active => false;

		public global::UnityEngine.Vector2 jitterVector { get; private set; }

		public override global::UnityEngine.DepthTextureMode GetCameraFlags()
		{
			return default(global::UnityEngine.DepthTextureMode);
		}

		public void ResetHistory()
		{
		}

		public void SetProjectionMatrix(global::System.Func<global::UnityEngine.Vector2, global::UnityEngine.Matrix4x4> jitteredFunc)
		{
		}

		public void Render(global::UnityEngine.RenderTexture source, global::UnityEngine.RenderTexture destination)
		{
		}

		private float GetHaltonValue(int index, int radix)
		{
			return 0f;
		}

		private global::UnityEngine.Vector2 GenerateRandomOffset()
		{
			return default(global::UnityEngine.Vector2);
		}

		private global::UnityEngine.Matrix4x4 GetPerspectiveProjectionMatrix(global::UnityEngine.Vector2 offset)
		{
			return default(global::UnityEngine.Matrix4x4);
		}

		private global::UnityEngine.Matrix4x4 GetOrthographicProjectionMatrix(global::UnityEngine.Vector2 offset)
		{
			return default(global::UnityEngine.Matrix4x4);
		}

		public override void OnDisable()
		{
		}
	}
}
