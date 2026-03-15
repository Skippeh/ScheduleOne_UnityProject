namespace ScheduleOne.Weather
{
	public static class EnvironmentHandler
	{
		private static global::ScheduleOne.Weather.WeatherChangeHandler _onWeatherChange;

		private static global::ScheduleOne.Weather.WeatherEntityHandler _onRegisterWeatherEntity;

		private static global::ScheduleOne.Weather.WeatherEntityHandler _onUnregisterWeatherEntity;

		public static void RaiseWeatherChange(global::ScheduleOne.Weather.WeatherConditions newConditions)
		{
		}

		public static void RegisterWeatherEntity(global::ScheduleOne.Weather.IWeatherEntity entity)
		{
		}

		public static void UnregisterWeatherEntity(global::ScheduleOne.Weather.IWeatherEntity entity)
		{
		}

		public static void SubscribeToWeatherChange(global::ScheduleOne.Weather.WeatherChangeHandler handler)
		{
		}

		public static void UnsubscribeFromWeatherChange(global::ScheduleOne.Weather.WeatherChangeHandler handler)
		{
		}

		public static void SubscribeToOnRegisterWeatherEntity(global::ScheduleOne.Weather.WeatherEntityHandler handler)
		{
		}

		public static void UnsubscribeFromOnRegisterWeatherEntity(global::ScheduleOne.Weather.WeatherEntityHandler handler)
		{
		}

		public static void SubscribeToOnUnregisterWeatherEntity(global::ScheduleOne.Weather.WeatherEntityHandler handler)
		{
		}

		public static void UnsubscribeFromOnUnregisterWeatherEntity(global::ScheduleOne.Weather.WeatherEntityHandler handler)
		{
		}
	}
}
