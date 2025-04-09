using System;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class UserLutModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture2D lut;

			[Range(0f, 1f)]
			[Tooltip("Blending factor.")]
			public float contribution;

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
