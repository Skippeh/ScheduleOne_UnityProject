using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class ViolatingCurfew : Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
