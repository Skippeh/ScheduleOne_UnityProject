namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class ColorGradingModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		public enum Tonemapper
		{
			None = 0,
			ACES = 1,
			Neutral = 2
		}

		[global::System.Serializable]
		public struct TonemappingSettings
		{
			[global::UnityEngine.Tooltip("Tonemapping algorithm to use at the end of the color grading process. Use \"Neutral\" if you need a customizable tonemapper or \"Filmic\" to give a standard filmic look to your scenes.")]
			public global::UnityEngine.PostProcessing.ColorGradingModel.Tonemapper tonemapper;

			[global::UnityEngine.Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			[global::UnityEngine.Range(1f, 20f)]
			public float neutralWhiteIn;

			[global::UnityEngine.Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			[global::UnityEngine.Range(1f, 19f)]
			public float neutralWhiteOut;

			[global::UnityEngine.Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			[global::UnityEngine.Range(1f, 10f)]
			public float neutralWhiteClip;

			public static global::UnityEngine.PostProcessing.ColorGradingModel.TonemappingSettings defaultSettings => default(global::UnityEngine.PostProcessing.ColorGradingModel.TonemappingSettings);
		}

		[global::System.Serializable]
		public struct BasicSettings
		{
			[global::UnityEngine.Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
			public float postExposure;

			[global::UnityEngine.Range(-100f, 100f)]
			[global::UnityEngine.Tooltip("Sets the white balance to a custom color temperature.")]
			public float temperature;

			[global::UnityEngine.Range(-100f, 100f)]
			[global::UnityEngine.Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			public float tint;

			[global::UnityEngine.Range(-180f, 180f)]
			[global::UnityEngine.Tooltip("Shift the hue of all colors.")]
			public float hueShift;

			[global::UnityEngine.Range(0f, 2f)]
			[global::UnityEngine.Tooltip("Pushes the intensity of all colors.")]
			public float saturation;

			[global::UnityEngine.Range(0f, 2f)]
			[global::UnityEngine.Tooltip("Expands or shrinks the overall range of tonal values.")]
			public float contrast;

			public static global::UnityEngine.PostProcessing.ColorGradingModel.BasicSettings defaultSettings => default(global::UnityEngine.PostProcessing.ColorGradingModel.BasicSettings);
		}

		[global::System.Serializable]
		public struct ChannelMixerSettings
		{
			public global::UnityEngine.Vector3 red;

			public global::UnityEngine.Vector3 green;

			public global::UnityEngine.Vector3 blue;

			[global::UnityEngine.HideInInspector]
			public int currentEditingChannel;

			public static global::UnityEngine.PostProcessing.ColorGradingModel.ChannelMixerSettings defaultSettings => default(global::UnityEngine.PostProcessing.ColorGradingModel.ChannelMixerSettings);
		}

		[global::System.Serializable]
		public struct LogWheelsSettings
		{
			[global::UnityEngine.PostProcessing.Trackball("GetSlopeValue")]
			public global::UnityEngine.Color slope;

			[global::UnityEngine.PostProcessing.Trackball("GetPowerValue")]
			public global::UnityEngine.Color power;

			[global::UnityEngine.PostProcessing.Trackball("GetOffsetValue")]
			public global::UnityEngine.Color offset;

			public static global::UnityEngine.PostProcessing.ColorGradingModel.LogWheelsSettings defaultSettings => default(global::UnityEngine.PostProcessing.ColorGradingModel.LogWheelsSettings);
		}

		[global::System.Serializable]
		public struct LinearWheelsSettings
		{
			[global::UnityEngine.PostProcessing.Trackball("GetLiftValue")]
			public global::UnityEngine.Color lift;

			[global::UnityEngine.PostProcessing.Trackball("GetGammaValue")]
			public global::UnityEngine.Color gamma;

			[global::UnityEngine.PostProcessing.Trackball("GetGainValue")]
			public global::UnityEngine.Color gain;

			public static global::UnityEngine.PostProcessing.ColorGradingModel.LinearWheelsSettings defaultSettings => default(global::UnityEngine.PostProcessing.ColorGradingModel.LinearWheelsSettings);
		}

		public enum ColorWheelMode
		{
			Linear = 0,
			Log = 1
		}

		[global::System.Serializable]
		public struct ColorWheelsSettings
		{
			public global::UnityEngine.PostProcessing.ColorGradingModel.ColorWheelMode mode;

			[global::UnityEngine.PostProcessing.TrackballGroup]
			public global::UnityEngine.PostProcessing.ColorGradingModel.LogWheelsSettings log;

			[global::UnityEngine.PostProcessing.TrackballGroup]
			public global::UnityEngine.PostProcessing.ColorGradingModel.LinearWheelsSettings linear;

			public static global::UnityEngine.PostProcessing.ColorGradingModel.ColorWheelsSettings defaultSettings => default(global::UnityEngine.PostProcessing.ColorGradingModel.ColorWheelsSettings);
		}

		[global::System.Serializable]
		public struct CurvesSettings
		{
			public global::UnityEngine.PostProcessing.ColorGradingCurve master;

			public global::UnityEngine.PostProcessing.ColorGradingCurve red;

			public global::UnityEngine.PostProcessing.ColorGradingCurve green;

			public global::UnityEngine.PostProcessing.ColorGradingCurve blue;

			public global::UnityEngine.PostProcessing.ColorGradingCurve hueVShue;

			public global::UnityEngine.PostProcessing.ColorGradingCurve hueVSsat;

			public global::UnityEngine.PostProcessing.ColorGradingCurve satVSsat;

			public global::UnityEngine.PostProcessing.ColorGradingCurve lumVSsat;

			[global::UnityEngine.HideInInspector]
			public int e_CurrentEditingCurve;

			[global::UnityEngine.HideInInspector]
			public bool e_CurveY;

			[global::UnityEngine.HideInInspector]
			public bool e_CurveR;

			[global::UnityEngine.HideInInspector]
			public bool e_CurveG;

			[global::UnityEngine.HideInInspector]
			public bool e_CurveB;

			public static global::UnityEngine.PostProcessing.ColorGradingModel.CurvesSettings defaultSettings => default(global::UnityEngine.PostProcessing.ColorGradingModel.CurvesSettings);
		}

		[global::System.Serializable]
		public struct Settings
		{
			public global::UnityEngine.PostProcessing.ColorGradingModel.TonemappingSettings tonemapping;

			public global::UnityEngine.PostProcessing.ColorGradingModel.BasicSettings basic;

			public global::UnityEngine.PostProcessing.ColorGradingModel.ChannelMixerSettings channelMixer;

			public global::UnityEngine.PostProcessing.ColorGradingModel.ColorWheelsSettings colorWheels;

			public global::UnityEngine.PostProcessing.ColorGradingModel.CurvesSettings curves;

			public static global::UnityEngine.PostProcessing.ColorGradingModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.ColorGradingModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.ColorGradingModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.ColorGradingModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.ColorGradingModel.Settings);
			}
			set
			{
			}
		}

		public bool isDirty { get; internal set; }

		public global::UnityEngine.RenderTexture bakedLut { get; internal set; }

		public override void Reset()
		{
		}

		public override void OnValidate()
		{
		}
	}
}
