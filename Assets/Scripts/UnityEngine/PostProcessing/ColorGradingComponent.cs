namespace UnityEngine.PostProcessing
{
	public sealed class ColorGradingComponent : PostProcessingComponentRenderTexture<ColorGradingModel>
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

		private Texture2D m_GradingCurves;

		private Color[] m_pixels;

		public override bool active => false;

		private float StandardIlluminantY(float x)
		{
			return 0f;
		}

		private Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		private Vector3 CalculateColorBalance(float temperature, float tint)
		{
			return default(Vector3);
		}

		private static Color NormalizeColor(Color c)
		{
			return default(Color);
		}

		private static Vector3 ClampVector(Vector3 v, float min, float max)
		{
			return default(Vector3);
		}

		public static Vector3 GetLiftValue(Color lift)
		{
			return default(Vector3);
		}

		public static Vector3 GetGammaValue(Color gamma)
		{
			return default(Vector3);
		}

		public static Vector3 GetGainValue(Color gain)
		{
			return default(Vector3);
		}

		public static void CalculateLiftGammaGain(Color lift, Color gamma, Color gain, out Vector3 outLift, out Vector3 outGamma, out Vector3 outGain)
		{
			outLift = default(Vector3);
			outGamma = default(Vector3);
			outGain = default(Vector3);
		}

		public static Vector3 GetSlopeValue(Color slope)
		{
			return default(Vector3);
		}

		public static Vector3 GetPowerValue(Color power)
		{
			return default(Vector3);
		}

		public static Vector3 GetOffsetValue(Color offset)
		{
			return default(Vector3);
		}

		public static void CalculateSlopePowerOffset(Color slope, Color power, Color offset, out Vector3 outSlope, out Vector3 outPower, out Vector3 outOffset)
		{
			outSlope = default(Vector3);
			outPower = default(Vector3);
			outOffset = default(Vector3);
		}

		private TextureFormat GetCurveFormat()
		{
			return default(TextureFormat);
		}

		private Texture2D GetCurveTexture()
		{
			return null;
		}

		private bool IsLogLutValid(RenderTexture lut)
		{
			return false;
		}

		private RenderTextureFormat GetLutFormat()
		{
			return default(RenderTextureFormat);
		}

		private void GenerateLut()
		{
		}

		public override void Prepare(Material uberMaterial)
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
