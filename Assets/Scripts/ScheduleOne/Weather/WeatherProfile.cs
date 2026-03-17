namespace ScheduleOne.Weather
{
	[global::UnityEngine.CreateAssetMenu(fileName = "WeatherProfile", menuName = "ScriptableObjects/Weather/Weather Profile")]
	public class WeatherProfile : global::UnityEngine.ScriptableObject
	{
		[global::UnityEngine.SerializeField]
		private string _id;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.SkySettings _skySettings;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.WeatherVolume _weatherVolumePrefab;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.WeatherConditions _conditions;

		public string Id => null;

		public global::ScheduleOne.Weather.WeatherVolume WeatherVolumePrefab => null;

		public global::ScheduleOne.Weather.SkySettings SkySettings => null;

		public global::ScheduleOne.Weather.WeatherConditions Conditions => null;
	}
}
