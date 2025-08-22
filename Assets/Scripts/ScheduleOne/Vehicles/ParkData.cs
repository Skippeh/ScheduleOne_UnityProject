namespace ScheduleOne.Vehicles
{
	[global::System.Serializable]
	public class ParkData
	{
		public global::System.Guid lotGUID;

		public int spotIndex;

		public global::ScheduleOne.Vehicles.EParkingAlignment alignment;

		public ParkData(global::System.Guid lotGUID, int spotIndex, global::ScheduleOne.Vehicles.EParkingAlignment alignment)
		{
		}

		public ParkData()
		{
		}
	}
}
