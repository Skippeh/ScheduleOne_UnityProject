using System;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class ChromaticAberrationModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			[Tooltip("Shift the hue of chromatic aberrations.")]
			public Texture2D spectralTexture;

			[Range(0f, 1f)]
			[Tooltip("Amount of tangential distortion.")]
			public float intensity;

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
