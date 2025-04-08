namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class GrainModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		[global::System.Serializable]
		public struct Settings
		{
			[global::UnityEngine.Tooltip("Enable the use of colored grain.")]
			public bool colored;

			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("Grain strength. Higher means more visible grain.")]
			public float intensity;

			[global::UnityEngine.Range(0.3f, 3f)]
			[global::UnityEngine.Tooltip("Grain particle size.")]
			public float size;

			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("Controls the noisiness response curve based on scene luminance. Lower values mean less noise in dark areas.")]
			public float luminanceContribution;

			public static global::UnityEngine.PostProcessing.GrainModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.GrainModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.GrainModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.GrainModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.GrainModel.Settings);
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
