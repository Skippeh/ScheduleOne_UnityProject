using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class VehicularAssault : Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
