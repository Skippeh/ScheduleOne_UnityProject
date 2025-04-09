using System;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class VignetteModel : PostProcessingModel
	{
		public enum Mode
		{
			Classic = 0,
			Masked = 1
		}

		[Serializable]
		public struct Settings
		{
			[Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
			public Mode mode;

			[ColorUsage(false)]
			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			public Color color;

			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			[Range(0f, 1f)]
			[Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			[Range(0.01f, 1f)]
			[Tooltip("Smoothness of the vignette borders.")]
			public float smoothness;

			[Range(0f, 1f)]
			[Tooltip("Lower values will make a square-ish vignette.")]
			public float roundness;

			[Tooltip("A black and white mask to use as a vignette.")]
			public Texture mask;

			[Range(0f, 1f)]
			[Tooltip("Mask opacity.")]
			public float opacity;

			[Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
			public bool rounded;

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

		public override void Reset()
		{
		}
	}
}
