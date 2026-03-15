namespace ScheduleOne.Configuration
{
	public class ConfigurationService : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.Configuration.ConfigurationService>
	{
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Configuration.BaseConfiguration[] _configurations;

		public global::ScheduleOne.Configuration.BaseConfiguration[] Configurations => null;

		protected override void Awake()
		{
		}

		private void ResetConfigurations()
		{
		}

		public bool TryGetConfiguration<T>(out T configuration) where T : global::ScheduleOne.Configuration.BaseConfiguration
		{
			configuration = null;
			return false;
		}

		public bool TryGetConfiguration(string configurationName, out global::ScheduleOne.Configuration.BaseConfiguration configuration)
		{
			configuration = null;
			return false;
		}

		public void GetConfigurationAndListenForChanges<T>(global::System.Action<global::ScheduleOne.Configuration.BaseConfiguration> onConfigChanged) where T : global::ScheduleOne.Configuration.BaseConfiguration
		{
		}

		public void UnsubscribeFromConfigurationChanges<T>(global::System.Action<global::ScheduleOne.Configuration.BaseConfiguration> onConfigChanged) where T : global::ScheduleOne.Configuration.BaseConfiguration
		{
		}
	}
}
