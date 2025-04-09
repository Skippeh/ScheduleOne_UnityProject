namespace ScheduleOne.Management
{
	public abstract class ConfigField
	{
		public EntityConfiguration ParentConfig { get; protected set; }

		public ConfigField(EntityConfiguration parentConfig)
		{
		}

		public abstract bool IsValueDefault();
	}
}
