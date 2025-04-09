using System;

namespace ScheduleOne
{
	public interface IGUIDRegisterable
	{
		Guid GUID { get; }

		void SetGUID(string guid)
		{
		}

		void SetGUID(Guid guid);
	}
}
