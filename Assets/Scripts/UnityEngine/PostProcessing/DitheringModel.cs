namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class DitheringModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		[global::System.Serializable]
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Size = 1)]
		public struct Settings
		{
			public static global::UnityEngine.PostProcessing.DitheringModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.DitheringModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.DitheringModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.DitheringModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.DitheringModel.Settings);
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
