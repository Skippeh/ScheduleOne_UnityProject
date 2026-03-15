namespace ScheduleOne.Weather
{
	public interface IWeatherEntity
	{
		string WeatherVolume { get; set; }

		global::UnityEngine.Transform Transform { get; }

		bool IsUnderCover { get; set; }

		void OnWeatherChange(global::ScheduleOne.Weather.WeatherConditions newConditions);
	}
}
