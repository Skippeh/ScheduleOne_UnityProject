namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class VignetteModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		public enum Mode
		{
			Classic = 0,
			Masked = 1
		}

		[global::System.Serializable]
		public struct Settings
		{
			[global::UnityEngine.Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
			public global::UnityEngine.PostProcessing.VignetteModel.Mode mode;

			[global::UnityEngine.ColorUsage(false)]
			[global::UnityEngine.Tooltip("Vignette color. Use the alpha channel for transparency.")]
			public global::UnityEngine.Color color;

			[global::UnityEngine.Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public global::UnityEngine.Vector2 center;

			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			[global::UnityEngine.Range(0.01f, 1f)]
			[global::UnityEngine.Tooltip("Smoothness of the vignette borders.")]
			public float smoothness;

			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("Lower values will make a square-ish vignette.")]
			public float roundness;

			[global::UnityEngine.Tooltip("A black and white mask to use as a vignette.")]
			public global::UnityEngine.Texture mask;

			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("Mask opacity.")]
			public float opacity;

			[global::UnityEngine.Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
			public bool rounded;

			public static global::UnityEngine.PostProcessing.VignetteModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.VignetteModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.VignetteModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.VignetteModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.VignetteModel.Settings);
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
