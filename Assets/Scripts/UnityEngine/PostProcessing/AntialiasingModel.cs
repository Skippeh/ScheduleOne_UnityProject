namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class AntialiasingModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		public enum Method
		{
			Fxaa = 0,
			Taa = 1
		}

		public enum FxaaPreset
		{
			ExtremePerformance = 0,
			Performance = 1,
			Default = 2,
			Quality = 3,
			ExtremeQuality = 4
		}

		[global::System.Serializable]
		public struct FxaaQualitySettings
		{
			[global::UnityEngine.Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
			[global::UnityEngine.Range(0f, 1f)]
			public float subpixelAliasingRemovalAmount;

			[global::UnityEngine.Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			[global::UnityEngine.Range(0.063f, 0.333f)]
			public float edgeDetectionThreshold;

			[global::UnityEngine.Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[global::UnityEngine.Range(0f, 0.0833f)]
			public float minimumRequiredLuminance;

			public static global::UnityEngine.PostProcessing.AntialiasingModel.FxaaQualitySettings[] presets;
		}

		[global::System.Serializable]
		public struct FxaaConsoleSettings
		{
			[global::UnityEngine.Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
			[global::UnityEngine.Range(0.33f, 0.5f)]
			public float subpixelSpreadAmount;

			[global::UnityEngine.Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
			[global::UnityEngine.Range(2f, 8f)]
			public float edgeSharpnessAmount;

			[global::UnityEngine.Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			[global::UnityEngine.Range(0.125f, 0.25f)]
			public float edgeDetectionThreshold;

			[global::UnityEngine.Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[global::UnityEngine.Range(0.04f, 0.06f)]
			public float minimumRequiredLuminance;

			public static global::UnityEngine.PostProcessing.AntialiasingModel.FxaaConsoleSettings[] presets;
		}

		[global::System.Serializable]
		public struct FxaaSettings
		{
			public global::UnityEngine.PostProcessing.AntialiasingModel.FxaaPreset preset;

			public static global::UnityEngine.PostProcessing.AntialiasingModel.FxaaSettings defaultSettings => default(global::UnityEngine.PostProcessing.AntialiasingModel.FxaaSettings);
		}

		[global::System.Serializable]
		public struct TaaSettings
		{
			[global::UnityEngine.Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable but blurrier output.")]
			[global::UnityEngine.Range(0.1f, 1f)]
			public float jitterSpread;

			[global::UnityEngine.Tooltip("Controls the amount of sharpening applied to the color buffer.")]
			[global::UnityEngine.Range(0f, 3f)]
			public float sharpen;

			[global::UnityEngine.Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
			[global::UnityEngine.Range(0f, 0.99f)]
			public float stationaryBlending;

			[global::UnityEngine.Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
			[global::UnityEngine.Range(0f, 0.99f)]
			public float motionBlending;

			public static global::UnityEngine.PostProcessing.AntialiasingModel.TaaSettings defaultSettings => default(global::UnityEngine.PostProcessing.AntialiasingModel.TaaSettings);
		}

		[global::System.Serializable]
		public struct Settings
		{
			public global::UnityEngine.PostProcessing.AntialiasingModel.Method method;

			public global::UnityEngine.PostProcessing.AntialiasingModel.FxaaSettings fxaaSettings;

			public global::UnityEngine.PostProcessing.AntialiasingModel.TaaSettings taaSettings;

			public static global::UnityEngine.PostProcessing.AntialiasingModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.AntialiasingModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.AntialiasingModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.AntialiasingModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.AntialiasingModel.Settings);
			}
			set
			{
			}
		}

		public override void Reset()
		{
		}
	}
}
