using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class TransportingIllicitItems : Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
