using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class PossessingHighSeverityDrug : Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
