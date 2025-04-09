using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class DrugTrafficking : Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
