using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class Theft : Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
