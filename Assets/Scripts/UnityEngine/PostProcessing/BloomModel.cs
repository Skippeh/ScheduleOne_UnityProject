namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class BloomModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		[global::System.Serializable]
		public struct BloomSettings
		{
			[global::UnityEngine.PostProcessing.Min(0f)]
			[global::UnityEngine.Tooltip("Strength of the bloom filter.")]
			public float intensity;

			[global::UnityEngine.PostProcessing.Min(0f)]
			[global::UnityEngine.Tooltip("Filters out pixels under this level of brightness.")]
			public float threshold;

			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("Makes transition between under/over-threshold gradual (0 = hard threshold, 1 = soft threshold).")]
			public float softKnee;

			[global::UnityEngine.Range(1f, 7f)]
			[global::UnityEngine.Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
			public float radius;

			[global::UnityEngine.Tooltip("Reduces flashing noise with an additional filter.")]
			public bool antiFlicker;

			public float thresholdLinear
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public static global::UnityEngine.PostProcessing.BloomModel.BloomSettings defaultSettings => default(global::UnityEngine.PostProcessing.BloomModel.BloomSettings);
		}

		[global::System.Serializable]
		public struct LensDirtSettings
		{
			[global::UnityEngine.Tooltip("Dirtiness texture to add smudges or dust to the lens.")]
			public global::UnityEngine.Texture texture;

			[global::UnityEngine.PostProcessing.Min(0f)]
			[global::UnityEngine.Tooltip("Amount of lens dirtiness.")]
			public float intensity;

			public static global::UnityEngine.PostProcessing.BloomModel.LensDirtSettings defaultSettings => default(global::UnityEngine.PostProcessing.BloomModel.LensDirtSettings);
		}

		[global::System.Serializable]
		public struct Settings
		{
			public global::UnityEngine.PostProcessing.BloomModel.BloomSettings bloom;

			public global::UnityEngine.PostProcessing.BloomModel.LensDirtSettings lensDirt;

			public static global::UnityEngine.PostProcessing.BloomModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.BloomModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.BloomModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.BloomModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.BloomModel.Settings);
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
