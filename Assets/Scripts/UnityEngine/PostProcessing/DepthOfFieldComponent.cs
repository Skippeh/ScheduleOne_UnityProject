namespace UnityEngine.PostProcessing
{
	public sealed class DepthOfFieldComponent : global::UnityEngine.PostProcessing.PostProcessingComponentRenderTexture<global::UnityEngine.PostProcessing.DepthOfFieldModel>
	{
		private static class Uniforms
		{
			internal static readonly int _DepthOfFieldTex;

			internal static readonly int _DepthOfFieldCoCTex;

			internal static readonly int _Distance;

			internal static readonly int _LensCoeff;

			internal static readonly int _MaxCoC;

			internal static readonly int _RcpMaxCoC;

			internal static readonly int _RcpAspect;

			internal static readonly int _MainTex;

			internal static readonly int _CoCTex;

			internal static readonly int _TaaParams;

			internal static readonly int _DepthOfFieldParams;
		}

		private const string k_ShaderString = "Hidden/Post FX/Depth Of Field";

		private global::UnityEngine.RenderTexture m_CoCHistory;

		private const float k_FilmHeight = 0.024f;

		public override bool active => false;

		public override global::UnityEngine.DepthTextureMode GetCameraFlags()
		{
			return default(global::UnityEngine.DepthTextureMode);
		}

		private float CalculateFocalLength()
		{
			return 0f;
		}

		private float CalculateMaxCoCRadius(int screenHeight)
		{
			return 0f;
		}

		private bool CheckHistory(int width, int height)
		{
			return false;
		}

		private global::UnityEngine.RenderTextureFormat SelectFormat(global::UnityEngine.RenderTextureFormat primary, global::UnityEngine.RenderTextureFormat secondary)
		{
			return default(global::UnityEngine.RenderTextureFormat);
		}

		public void Prepare(global::UnityEngine.RenderTexture source, global::UnityEngine.Material uberMaterial, bool antialiasCoC, global::UnityEngine.Vector2 taaJitter, float taaBlending)
		{
		}

		public override void OnDisable()
		{
		}
	}
}
