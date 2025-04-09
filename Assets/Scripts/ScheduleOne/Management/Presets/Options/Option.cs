namespace ScheduleOne.Management.Presets.Options
{
	public abstract class Option
	{
		public string Name { get; protected set; }

		public Option(string name)
		{
		}

		public virtual void CopyTo(Option other)
		{
		}

		public abstract string GetDisplayString();
	}
}
