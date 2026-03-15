namespace ScheduleOne.Configuration
{
	public abstract class BaseConfiguration : global::UnityEngine.ScriptableObject
	{
		public global::System.Action<global::ScheduleOne.Configuration.BaseConfiguration> OnConfigurationChanged;

		public abstract void ResetConfigurationToDefault();

		public virtual void ValidateConfiguration()
		{
		}

		public abstract global::ScheduleOne.Core.Settings.Framework.Settings GetSettings();
	}
}
