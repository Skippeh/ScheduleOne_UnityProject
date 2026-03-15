namespace ScheduleOne.Configuration
{
	public abstract class Configuration<T> : global::ScheduleOne.Configuration.BaseConfiguration where T : global::ScheduleOne.Core.Settings.Framework.Settings
	{
		public T Settings { get; private set; }

		private T DefaultSettings { get; set; }

		public override void ValidateConfiguration()
		{
		}

		public override void ResetConfigurationToDefault()
		{
		}

		public override global::ScheduleOne.Core.Settings.Framework.Settings GetSettings()
		{
			return null;
		}

		public void ApplySettings(T newSettings)
		{
		}

		private static void ApplyOverwrites(T from, T to)
		{
		}
	}
}
