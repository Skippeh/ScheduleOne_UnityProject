using System;

namespace ScheduleOne.Vehicles
{
	[Serializable]
	public class ParkData
	{
		public Guid lotGUID;

		public int spotIndex;

		public EParkingAlignment alignment;
	}
}
