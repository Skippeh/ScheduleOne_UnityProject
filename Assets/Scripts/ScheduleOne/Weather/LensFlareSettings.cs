namespace ScheduleOne.Weather
{
	[global::UnityEngine.CreateAssetMenu(fileName = "LensFlareSettings", menuName = "ScriptableObjects/Weather/Lens Flare Settings")]
	public class LensFlareSettings : global::UnityEngine.ScriptableObject
	{
		[global::System.Serializable]
		public class LensFlareSettingsGroup
		{
			public global::UnityEngine.Rendering.LensFlareDataSRP LensFlare;

			public float Intensity;
		}

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.LensFlareSettings.LensFlareSettingsGroup[] lensFlareGroups;

		public bool TryGetLensFlareSettings(global::UnityEngine.Rendering.LensFlareDataSRP lensFlare, out global::ScheduleOne.Weather.LensFlareSettings.LensFlareSettingsGroup group)
		{
			group = null;
			return false;
		}

		public global::ScheduleOne.Weather.LensFlareSettings.LensFlareSettingsGroup[] GetLensFlareGroups()
		{
			return null;
		}
	}
}
