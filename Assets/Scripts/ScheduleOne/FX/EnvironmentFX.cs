namespace ScheduleOne.FX
{
	[global::UnityEngine.ExecuteInEditMode]
	public class EnvironmentFX : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.FX.EnvironmentFX>
	{
		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.WindZone windZone;

		[global::UnityEngine.SerializeField]
		protected global::Funly.SkyStudio.TimeOfDayController timeOfDayController;

		public global::VolumetricFogAndMist2.VolumetricFog VolumetricFog;

		public global::UnityEngine.Light SunLight;

		public global::UnityEngine.Light MoonLight;

		[global::UnityEngine.Header("Fog")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Gradient fogColorGradient;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve fogEndDistanceCurve;

		[global::UnityEngine.SerializeField]
		protected float fogEndDistanceMultiplier;

		[global::UnityEngine.Header("Height Fog")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Gradient HeightFogColor;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve HeightFogIntensityCurve;

		[global::UnityEngine.SerializeField]
		protected float HeightFogIntensityMultiplier;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve HeightFogDirectionalIntensityCurve;

		[global::UnityEngine.Header("Volumetric Fog")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Gradient VolumetricFogColor;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve VolumetricFogIntensityCurve;

		[global::UnityEngine.SerializeField]
		protected float VolumetricFogIntensityMultiplier;

		[global::UnityEngine.Header("God rays")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve godRayIntensityCurve;

		[global::UnityEngine.Header("Contrast")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve contrastCurve;

		[global::UnityEngine.SerializeField]
		protected float contractMultiplier;

		[global::UnityEngine.Header("Saturation")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve saturationCurve;

		[global::UnityEngine.SerializeField]
		protected float saturationMultiplier;

		[global::UnityEngine.Header("Grass")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material grassMat;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Gradient grassColorGradient;

		[global::UnityEngine.Header("Trees")]
		public global::UnityEngine.Material distanceTreeMat;

		public global::UnityEngine.AnimationCurve distanceTreeColorCurve;

		[global::UnityEngine.Header("Stealth settings")]
		public global::UnityEngine.AnimationCurve environmentalBrightnessCurve;

		[global::UnityEngine.Header("Bloom")]
		public global::UnityEngine.AnimationCurve bloomThreshholdCurve;

		private bool started;

		public global::ScheduleOne.Tools.FloatSmoother FogEndDistanceController;

		public float normalizedEnvironmentalBrightness => 0f;

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateVisuals()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
