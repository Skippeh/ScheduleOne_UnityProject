using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class PossessingModerateSeverityDrug : Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
