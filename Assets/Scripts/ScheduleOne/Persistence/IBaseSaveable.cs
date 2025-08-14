namespace ScheduleOne.Persistence
{
	public interface IBaseSaveable : global::ScheduleOne.Persistence.ISaveable
	{
		int LoadOrder { get; }
	}
}
