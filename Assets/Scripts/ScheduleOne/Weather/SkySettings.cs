namespace ScheduleOne.Weather
{
	[global::System.Serializable]
	public class SkySettings
	{
		[global::UnityEngine.SerializeField]
		private DynamicGradient _skyUpperGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _skyMiddleGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _skyLowerGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _cloudDensityGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _cloudColorGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _sunLightGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _sunIntensityGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _sunColorGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _sunSizeGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _moonLightGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _moonIntensityGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _moonColorGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _moonSizeGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _ambientSkyGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _ambientEquatorGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _ambientGroundGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _fogColorGradient;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _fogDensityGradient;

		public global::UnityEngine.Vector2 FogHeightFade;

		[global::UnityEngine.SerializeField]
		private DynamicGradient _windIntensityGradient;

		public DynamicGradient SkyUpperGradient => null;

		public DynamicGradient SkyMiddleGradient => null;

		public DynamicGradient SkyLowerGradient => null;

		public DynamicGradient CloudDensityGradient => null;

		public DynamicGradient CloudColorGradient => null;

		public DynamicGradient SunLightColorGradient => null;

		public DynamicGradient SunDiscColorGradient => null;

		public DynamicGradient MoonLightColorGradient => null;

		public DynamicGradient MoonDiscColorGradient => null;

		public DynamicGradient SunIntensityGradient => null;

		public DynamicGradient MoonIntensityGradient => null;

		public DynamicGradient AmbientSkyGradient => null;

		public DynamicGradient AmbientEquatorGradient => null;

		public DynamicGradient AmbientGroundGradient => null;

		public DynamicGradient FogColorGradient => null;

		public DynamicGradient FogDensityGradient => null;

		public DynamicGradient WindIntensityGradient => null;

		public DynamicGradient SunSizeGradient => null;

		public DynamicGradient MoonSizeGradient => null;

		public void Set(global::ScheduleOne.Weather.SkySettings settings)
		{
		}
	}
}
