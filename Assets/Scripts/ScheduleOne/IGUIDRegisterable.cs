namespace ScheduleOne
{
	public interface IGUIDRegisterable
	{
		global::System.Guid GUID { get; }

		void SetGUID(string guid)
		{
		}

		void SetGUID(global::System.Guid guid);
	}
}
