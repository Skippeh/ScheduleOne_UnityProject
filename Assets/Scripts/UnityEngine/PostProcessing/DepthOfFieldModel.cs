namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class DepthOfFieldModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		public enum KernelSize
		{
			Small = 0,
			Medium = 1,
			Large = 2,
			VeryLarge = 3
		}

		[global::System.Serializable]
		public struct Settings
		{
			[global::UnityEngine.PostProcessing.Min(0.1f)]
			[global::UnityEngine.Tooltip("Distance to the point of focus.")]
			public float focusDistance;

			[global::UnityEngine.Range(0.05f, 32f)]
			[global::UnityEngine.Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
			public float aperture;

			[global::UnityEngine.Range(1f, 300f)]
			[global::UnityEngine.Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
			public float focalLength;

			[global::UnityEngine.Tooltip("Calculate the focal length automatically from the field-of-view value set on the camera. Using this setting isn't recommended.")]
			public bool useCameraFov;

			[global::UnityEngine.Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects the performance (the larger the kernel is, the longer the GPU time is required).")]
			public global::UnityEngine.PostProcessing.DepthOfFieldModel.KernelSize kernelSize;

			public static global::UnityEngine.PostProcessing.DepthOfFieldModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.DepthOfFieldModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.DepthOfFieldModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.DepthOfFieldModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.DepthOfFieldModel.Settings);
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
