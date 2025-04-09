using System;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class FogModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			[Tooltip("Should the fog affect the skybox?")]
			public bool excludeSkybox;

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
