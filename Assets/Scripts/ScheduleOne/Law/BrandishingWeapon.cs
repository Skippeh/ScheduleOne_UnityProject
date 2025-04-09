using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class BrandishingWeapon : Crime
	{
		public override string CrimeName { get; protected set; }
	}
}
