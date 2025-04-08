namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class FogModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		[global::System.Serializable]
		public struct Settings
		{
			[global::UnityEngine.Tooltip("Should the fog affect the skybox?")]
			public bool excludeSkybox;

			public static global::UnityEngine.PostProcessing.FogModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.FogModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.FogModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.FogModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.FogModel.Settings);
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
