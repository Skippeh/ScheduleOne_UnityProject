namespace ScheduleOne.Weather
{
	[global::System.Serializable]
	public class WeatherConditions
	{
		[global::UnityEngine.Range(0f, 1f)]
		public float Sunny;

		[global::UnityEngine.Range(0f, 1f)]
		public float Cloudy;

		[global::UnityEngine.Range(0f, 1f)]
		public float Rainy;

		[global::UnityEngine.Range(0f, 1f)]
		public float Stormy;

		[global::UnityEngine.Range(0f, 1f)]
		public float Snowy;

		[global::UnityEngine.Range(0f, 1f)]
		public float Foggy;

		[global::UnityEngine.Range(0f, 1f)]
		public float Windy;

		[global::UnityEngine.Range(0f, 1f)]
		public float Hail;

		[global::UnityEngine.Range(0f, 1f)]
		public float Sleet;

		public void Set(global::ScheduleOne.Weather.WeatherConditions conditions)
		{
		}
	}
}
