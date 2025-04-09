using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class Assault : Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
