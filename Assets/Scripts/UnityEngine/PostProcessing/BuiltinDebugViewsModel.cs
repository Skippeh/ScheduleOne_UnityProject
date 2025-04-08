namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class BuiltinDebugViewsModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		[global::System.Serializable]
		public struct DepthSettings
		{
			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("Scales the camera far plane before displaying the depth map.")]
			public float scale;

			public static global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.DepthSettings defaultSettings => default(global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.DepthSettings);
		}

		[global::System.Serializable]
		public struct MotionVectorsSettings
		{
			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("Opacity of the source render.")]
			public float sourceOpacity;

			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("Opacity of the per-pixel motion vector colors.")]
			public float motionImageOpacity;

			[global::UnityEngine.PostProcessing.Min(0f)]
			[global::UnityEngine.Tooltip("Because motion vectors are mainly very small vectors, you can use this setting to make them more visible.")]
			public float motionImageAmplitude;

			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("Opacity for the motion vector arrows.")]
			public float motionVectorsOpacity;

			[global::UnityEngine.Range(8f, 64f)]
			[global::UnityEngine.Tooltip("The arrow density on screen.")]
			public int motionVectorsResolution;

			[global::UnityEngine.PostProcessing.Min(0f)]
			[global::UnityEngine.Tooltip("Tweaks the arrows length.")]
			public float motionVectorsAmplitude;

			public static global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.MotionVectorsSettings defaultSettings => default(global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.MotionVectorsSettings);
		}

		public enum Mode
		{
			None = 0,
			Depth = 1,
			Normals = 2,
			MotionVectors = 3,
			AmbientOcclusion = 4,
			EyeAdaptation = 5,
			FocusPlane = 6,
			PreGradingLog = 7,
			LogLut = 8,
			UserLut = 9
		}

		[global::System.Serializable]
		public struct Settings
		{
			public global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.Mode mode;

			public global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.DepthSettings depth;

			public global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.MotionVectorsSettings motionVectors;

			public static global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.Settings);
			}
			set
			{
			}
		}

		public bool willInterrupt => false;

		public override void Reset()
		{
		}

		public bool IsModeActive(global::UnityEngine.PostProcessing.BuiltinDebugViewsModel.Mode mode)
		{
			return false;
		}
	}
}
