namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class MotionBlurModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		[global::System.Serializable]
		public struct Settings
		{
			[global::UnityEngine.Range(0f, 360f)]
			[global::UnityEngine.Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
			public float shutterAngle;

			[global::UnityEngine.Range(4f, 32f)]
			[global::UnityEngine.Tooltip("The amount of sample points, which affects quality and performances.")]
			public int sampleCount;

			[global::UnityEngine.Range(0f, 1f)]
			[global::UnityEngine.Tooltip("The strength of multiple frame blending. The opacity of preceding frames are determined from this coefficient and time differences.")]
			public float frameBlending;

			public static global::UnityEngine.PostProcessing.MotionBlurModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.MotionBlurModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.MotionBlurModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.MotionBlurModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.MotionBlurModel.Settings);
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
