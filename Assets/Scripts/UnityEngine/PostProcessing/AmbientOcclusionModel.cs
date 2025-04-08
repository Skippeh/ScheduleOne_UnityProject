namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class AmbientOcclusionModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		public enum SampleCount
		{
			Lowest = 3,
			Low = 6,
			Medium = 10,
			High = 16
		}

		[global::System.Serializable]
		public struct Settings
		{
			[global::UnityEngine.Range(0f, 4f)]
			[global::UnityEngine.Tooltip("Degree of darkness produced by the effect.")]
			public float intensity;

			[global::UnityEngine.PostProcessing.Min(0.0001f)]
			[global::UnityEngine.Tooltip("Radius of sample points, which affects extent of darkened areas.")]
			public float radius;

			[global::UnityEngine.Tooltip("Number of sample points, which affects quality and performance.")]
			public global::UnityEngine.PostProcessing.AmbientOcclusionModel.SampleCount sampleCount;

			[global::UnityEngine.Tooltip("Halves the resolution of the effect to increase performance at the cost of visual quality.")]
			public bool downsampling;

			[global::UnityEngine.Tooltip("Forces compatibility with Forward rendered objects when working with the Deferred rendering path.")]
			public bool forceForwardCompatibility;

			[global::UnityEngine.Tooltip("Enables the ambient-only mode in that the effect only affects ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering.")]
			public bool ambientOnly;

			[global::UnityEngine.Tooltip("Toggles the use of a higher precision depth texture with the forward rendering path (may impact performances). Has no effect with the deferred rendering path.")]
			public bool highPrecision;

			public static global::UnityEngine.PostProcessing.AmbientOcclusionModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.AmbientOcclusionModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.AmbientOcclusionModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.AmbientOcclusionModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.AmbientOcclusionModel.Settings);
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
