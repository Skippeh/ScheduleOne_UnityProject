using System;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class ColorGradingModel : PostProcessingModel
	{
		public enum Tonemapper
		{
			None = 0,
			ACES = 1,
			Neutral = 2
		}

		[Serializable]
		public struct TonemappingSettings
		{
			[Tooltip("Tonemapping algorithm to use at the end of the color grading process. Use \"Neutral\" if you need a customizable tonemapper or \"Filmic\" to give a standard filmic look to your scenes.")]
			public Tonemapper tonemapper;

			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			[Range(1f, 20f)]
			public float neutralWhiteIn;

			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			[Range(1f, 19f)]
			public float neutralWhiteOut;

			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			[Range(1f, 10f)]
			public float neutralWhiteClip;

			public static TonemappingSettings defaultSettings => default(TonemappingSettings);
		}

		[Serializable]
		public struct BasicSettings
		{
			[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
			public float postExposure;

			[Range(-100f, 100f)]
			[Tooltip("Sets the white balance to a custom color temperature.")]
			public float temperature;

			[Range(-100f, 100f)]
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			public float tint;

			[Range(-180f, 180f)]
			[Tooltip("Shift the hue of all colors.")]
			public float hueShift;

			[Range(0f, 2f)]
			[Tooltip("Pushes the intensity of all colors.")]
			public float saturation;

			[Range(0f, 2f)]
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			public float contrast;

			public static BasicSettings defaultSettings => default(BasicSettings);
		}

		[Serializable]
		public struct ChannelMixerSettings
		{
			public Vector3 red;

			public Vector3 green;

			public Vector3 blue;

			[HideInInspector]
			public int currentEditingChannel;

			public static ChannelMixerSettings defaultSettings => default(ChannelMixerSettings);
		}

		[Serializable]
		public struct LogWheelsSettings
		{
			[Trackball("GetSlopeValue")]
			public Color slope;

			[Trackball("GetPowerValue")]
			public Color power;

			[Trackball("GetOffsetValue")]
			public Color offset;

			public static LogWheelsSettings defaultSettings => default(LogWheelsSettings);
		}

		[Serializable]
		public struct LinearWheelsSettings
		{
			[Trackball("GetLiftValue")]
			public Color lift;

			[Trackball("GetGammaValue")]
			public Color gamma;

			[Trackball("GetGainValue")]
			public Color gain;

			public static LinearWheelsSettings defaultSettings => default(LinearWheelsSettings);
		}

		public enum ColorWheelMode
		{
			Linear = 0,
			Log = 1
		}

		[Serializable]
		public struct ColorWheelsSettings
		{
			public ColorWheelMode mode;

			[TrackballGroup]
			public LogWheelsSettings log;

			[TrackballGroup]
			public LinearWheelsSettings linear;

			public static ColorWheelsSettings defaultSettings => default(ColorWheelsSettings);
		}

		[Serializable]
		public struct CurvesSettings
		{
			public ColorGradingCurve master;

			public ColorGradingCurve red;

			public ColorGradingCurve green;

			public ColorGradingCurve blue;

			public ColorGradingCurve hueVShue;

			public ColorGradingCurve hueVSsat;

			public ColorGradingCurve satVSsat;

			public ColorGradingCurve lumVSsat;

			[HideInInspector]
			public int e_CurrentEditingCurve;

			[HideInInspector]
			public bool e_CurveY;

			[HideInInspector]
			public bool e_CurveR;

			[HideInInspector]
			public bool e_CurveG;

			[HideInInspector]
			public bool e_CurveB;

			public static CurvesSettings defaultSettings => default(CurvesSettings);
		}

		[Serializable]
		public struct Settings
		{
			public TonemappingSettings tonemapping;

			public BasicSettings basic;

			public ChannelMixerSettings channelMixer;

			public ColorWheelsSettings colorWheels;

			public CurvesSettings curves;

			public static Settings defaultSettings => default(Settings);
		}

		[SerializeField]
		private Settings m_Settings;

		public Settings settings
		{
			get
			{
				return default(Settings);
			}
			set
			{
			}
		}

		public bool isDirty { get; internal set; }

		public RenderTexture bakedLut { get; internal set; }

		public override void Reset()
		{
		}

		public override void OnValidate()
		{
		}
	}
}
