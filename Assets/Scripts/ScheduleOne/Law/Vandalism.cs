using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class Vandalism : Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
