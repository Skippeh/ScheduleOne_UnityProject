namespace ScheduleOne.FX
{
	public class PostProcessingManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.FX.PostProcessingManager>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Rendering.Volume GlobalVolume;

		[global::UnityEngine.Header("Vignette")]
		public float Vig_DefaultIntensity;

		public float Vig_DefaultSmoothness;

		[global::UnityEngine.Header("Blur")]
		public float MinBlur;

		public float MaxBlur;

		[global::UnityEngine.Header("Smoothers")]
		public global::ScheduleOne.Tools.FloatSmoother ChromaticAberrationController;

		public global::ScheduleOne.Tools.FloatSmoother SaturationController;

		public global::ScheduleOne.Tools.FloatSmoother BloomController;

		public global::ScheduleOne.Tools.HDRColorSmoother ColorFilterController;

		private global::UnityEngine.Rendering.Universal.Vignette vig;

		private global::UnityEngine.Rendering.Universal.DepthOfField DoF;

		private global::CorgiGodRays.GodRaysVolume GodRays;

		private global::UnityEngine.Rendering.Universal.ColorAdjustments ColorAdjustments;

		private global::Beautify.Universal.Beautify beautifySettings;

		private global::UnityEngine.Rendering.Universal.Bloom bloom;

		private global::UnityEngine.Rendering.Universal.ChromaticAberration chromaticAberration;

		private global::UnityEngine.Rendering.Universal.ColorAdjustments colorAdjustments;

		protected override void Awake()
		{
		}

		public void Update()
		{
		}

		private void UpdateEffects()
		{
		}

		public void OverrideVignette(float intensity, float smoothness)
		{
		}

		public void ResetVignette()
		{
		}

		public void SetGodRayIntensity(float intensity)
		{
		}

		public void SetContrast(float value)
		{
		}

		public void SetSaturation(float value)
		{
		}

		public void SetBloomThreshold(float threshold)
		{
		}

		public void SetBlur(float blurLevel)
		{
		}
	}
}
