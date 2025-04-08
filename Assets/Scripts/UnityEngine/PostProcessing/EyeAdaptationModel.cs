namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class EyeAdaptationModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		public enum EyeAdaptationType
		{
			Progressive = 0,
			Fixed = 1
		}

		[global::System.Serializable]
		public struct Settings
		{
			[global::UnityEngine.Range(1f, 99f)]
			[global::UnityEngine.Tooltip("Filters the dark part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
			public float lowPercent;

			[global::UnityEngine.Range(1f, 99f)]
			[global::UnityEngine.Tooltip("Filters the bright part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
			public float highPercent;

			[global::UnityEngine.Tooltip("Minimum average luminance to consider for auto exposure (in EV).")]
			public float minLuminance;

			[global::UnityEngine.Tooltip("Maximum average luminance to consider for auto exposure (in EV).")]
			public float maxLuminance;

			[global::UnityEngine.PostProcessing.Min(0f)]
			[global::UnityEngine.Tooltip("Exposure bias. Use this to offset the global exposure of the scene.")]
			public float keyValue;

			[global::UnityEngine.Tooltip("Set this to true to let Unity handle the key value automatically based on average luminance.")]
			public bool dynamicKeyValue;

			[global::UnityEngine.Tooltip("Use \"Progressive\" if you want the auto exposure to be animated. Use \"Fixed\" otherwise.")]
			public global::UnityEngine.PostProcessing.EyeAdaptationModel.EyeAdaptationType adaptationType;

			[global::UnityEngine.PostProcessing.Min(0f)]
			[global::UnityEngine.Tooltip("Adaptation speed from a dark to a light environment.")]
			public float speedUp;

			[global::UnityEngine.PostProcessing.Min(0f)]
			[global::UnityEngine.Tooltip("Adaptation speed from a light to a dark environment.")]
			public float speedDown;

			[global::UnityEngine.Range(-16f, -1f)]
			[global::UnityEngine.Tooltip("Lower bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
			public int logMin;

			[global::UnityEngine.Range(1f, 16f)]
			[global::UnityEngine.Tooltip("Upper bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
			public int logMax;

			public static global::UnityEngine.PostProcessing.EyeAdaptationModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.EyeAdaptationModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.EyeAdaptationModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.EyeAdaptationModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.EyeAdaptationModel.Settings);
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
