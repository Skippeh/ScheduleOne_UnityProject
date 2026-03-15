namespace ScheduleOne.Weather
{
	[global::UnityEngine.CreateAssetMenu(fileName = "EnvironmentProfile", menuName = "ScriptableObjects/Weather/Environment Profile")]
	public class EnvironmentProfile : global::UnityEngine.ScriptableObject
	{
		[global::UnityEngine.Header("Sky profile (TEMP - REPLACING)")]
		[global::UnityEngine.SerializeField]
		private global::Funly.SkyStudio.SkyProfile _skyProfile;

		[global::UnityEngine.Header("Sky Settings")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.SkySettings _skySettings;

		public global::ScheduleOne.Weather.SkySettings SkySettings => null;

		public global::Funly.SkyStudio.SkyProfile GetSkyProfile()
		{
			return null;
		}
	}
}
