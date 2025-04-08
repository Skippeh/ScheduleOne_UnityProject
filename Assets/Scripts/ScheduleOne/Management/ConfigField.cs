namespace ScheduleOne.Management
{
	public abstract class ConfigField
	{
		public global::ScheduleOne.Management.EntityConfiguration ParentConfig { get; protected set; }

		public ConfigField(global::ScheduleOne.Management.EntityConfiguration parentConfig)
		{
		}

		public abstract bool IsValueDefault();
	}
}
