namespace UnityEngine.PostProcessing
{
	public sealed class ColorGradingComponent : global::UnityEngine.PostProcessing.PostProcessingComponentRenderTexture<global::UnityEngine.PostProcessing.ColorGradingModel>
	{
		private static class Uniforms
		{
			internal static readonly int _LutParams;

			internal static readonly int _NeutralTonemapperParams1;

			internal static readonly int _NeutralTonemapperParams2;

			internal static readonly int _HueShift;

			internal static readonly int _Saturation;

			internal static readonly int _Contrast;

			internal static readonly int _Balance;

			internal static readonly int _Lift;

			internal static readonly int _InvGamma;

			internal static readonly int _Gain;

			internal static readonly int _Slope;

			internal static readonly int _Power;

			internal static readonly int _Offset;

			internal static readonly int _ChannelMixerRed;

			internal static readonly int _ChannelMixerGreen;

			internal static readonly int _ChannelMixerBlue;

			internal static readonly int _Curves;

			internal static readonly int _LogLut;

			internal static readonly int _LogLut_Params;

			internal static readonly int _ExposureEV;
		}

		private const int k_InternalLogLutSize = 32;

		private const int k_CurvePrecision = 128;

		private const float k_CurveStep = 1f / 128f;

		private global::UnityEngine.Texture2D m_GradingCurves;

		private global::UnityEngine.Color[] m_pixels;

		public override bool active => false;

		private float StandardIlluminantY(float x)
		{
			return 0f;
		}

		private global::UnityEngine.Vector3 CIExyToLMS(float x, float y)
		{
			return default(global::UnityEngine.Vector3);
		}

		private global::UnityEngine.Vector3 CalculateColorBalance(float temperature, float tint)
		{
			return default(global::UnityEngine.Vector3);
		}

		private static global::UnityEngine.Color NormalizeColor(global::UnityEngine.Color c)
		{
			return default(global::UnityEngine.Color);
		}

		private static global::UnityEngine.Vector3 ClampVector(global::UnityEngine.Vector3 v, float min, float max)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 GetLiftValue(global::UnityEngine.Color lift)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 GetGammaValue(global::UnityEngine.Color gamma)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 GetGainValue(global::UnityEngine.Color gain)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static void CalculateLiftGammaGain(global::UnityEngine.Color lift, global::UnityEngine.Color gamma, global::UnityEngine.Color gain, out global::UnityEngine.Vector3 outLift, out global::UnityEngine.Vector3 outGamma, out global::UnityEngine.Vector3 outGain)
		{
			outLift = default(global::UnityEngine.Vector3);
			outGamma = default(global::UnityEngine.Vector3);
			outGain = default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 GetSlopeValue(global::UnityEngine.Color slope)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 GetPowerValue(global::UnityEngine.Color power)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 GetOffsetValue(global::UnityEngine.Color offset)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static void CalculateSlopePowerOffset(global::UnityEngine.Color slope, global::UnityEngine.Color power, global::UnityEngine.Color offset, out global::UnityEngine.Vector3 outSlope, out global::UnityEngine.Vector3 outPower, out global::UnityEngine.Vector3 outOffset)
		{
			outSlope = default(global::UnityEngine.Vector3);
			outPower = default(global::UnityEngine.Vector3);
			outOffset = default(global::UnityEngine.Vector3);
		}

		private global::UnityEngine.TextureFormat GetCurveFormat()
		{
			return default(global::UnityEngine.TextureFormat);
		}

		private global::UnityEngine.Texture2D GetCurveTexture()
		{
			return null;
		}

		private bool IsLogLutValid(global::UnityEngine.RenderTexture lut)
		{
			return false;
		}

		private global::UnityEngine.RenderTextureFormat GetLutFormat()
		{
			return default(global::UnityEngine.RenderTextureFormat);
		}

		private void GenerateLut()
		{
		}

		public override void Prepare(global::UnityEngine.Material uberMaterial)
		{
		}

		public void OnGUI()
		{
		}

		public override void OnDisable()
		{
		}
	}
}
