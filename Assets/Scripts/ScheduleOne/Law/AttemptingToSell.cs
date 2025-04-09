using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class AttemptingToSell : Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
