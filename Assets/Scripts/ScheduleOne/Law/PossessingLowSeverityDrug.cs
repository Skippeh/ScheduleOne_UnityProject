using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class PossessingLowSeverityDrug : Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
