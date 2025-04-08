namespace ScheduleOne.Management.Presets.Options
{
	public abstract class Option
	{
		public string Name { get; protected set; }

		public Option(string name)
		{
		}

		public virtual void CopyTo(global::ScheduleOne.Management.Presets.Options.Option other)
		{
		}

		public abstract string GetDisplayString();
	}
}
