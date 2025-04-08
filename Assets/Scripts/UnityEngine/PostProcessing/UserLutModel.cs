namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class UserLutModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		[global::System.Serializable]
		public struct Settings
		{
			[global::UnityEngine.Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public global::UnityEngine.Texture2D lut;

			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("Blending factor.")]
			public float contribution;

			public static global::UnityEngine.PostProcessing.UserLutModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.UserLutModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.UserLutModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.UserLutModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.UserLutModel.Settings);
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
