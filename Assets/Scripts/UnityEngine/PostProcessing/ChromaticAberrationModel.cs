namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class ChromaticAberrationModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		[global::System.Serializable]
		public struct Settings
		{
			[global::UnityEngine.Tooltip("Shift the hue of chromatic aberrations.")]
			public global::UnityEngine.Texture2D spectralTexture;

			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("Amount of tangential distortion.")]
			public float intensity;

			public static global::UnityEngine.PostProcessing.ChromaticAberrationModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.ChromaticAberrationModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.ChromaticAberrationModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.ChromaticAberrationModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.ChromaticAberrationModel.Settings);
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
