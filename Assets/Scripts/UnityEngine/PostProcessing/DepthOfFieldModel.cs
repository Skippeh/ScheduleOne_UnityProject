using System;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class DepthOfFieldModel : PostProcessingModel
	{
		public enum KernelSize
		{
			Small = 0,
			Medium = 1,
			Large = 2,
			VeryLarge = 3
		}

		[Serializable]
		public struct Settings
		{
			[Min(0.1f)]
			[Tooltip("Distance to the point of focus.")]
			public float focusDistance;

			[Range(0.05f, 32f)]
			[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
			public float aperture;

			[Range(1f, 300f)]
			[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
			public float focalLength;

			[Tooltip("Calculate the focal length automatically from the field-of-view value set on the camera. Using this setting isn't recommended.")]
			public bool useCameraFov;

			[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects the performance (the larger the kernel is, the longer the GPU time is required).")]
			public KernelSize kernelSize;

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
