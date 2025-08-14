namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class CartelData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		[global::System.Serializable]
		public class RegionIntDict : global::ScheduleOne.Persistence.SerializableDictionary<global::ScheduleOne.Map.EMapRegion, int>
		{
		}

		public ECartelStatus Status;

		public int HoursSinceStatusChange;

		public global::ScheduleOne.Cartel.CartelInfluence.RegionInfluenceData[] RegionInfluence;

		public int HoursUntilNextGlobalActivity;

		public global::ScheduleOne.Persistence.CartelRegionalActivityData[] RegionalActivityData;

		public global::ScheduleOne.Cartel.CartelDealInfo ActiveCartelDeal;

		public int HoursUntilNextDealRequest;

		public CartelData(ECartelStatus status, int hoursSinceStatusChange, global::ScheduleOne.Cartel.CartelInfluence.RegionInfluenceData[] regionInfluence, int hoursUntilNextGlobalActivity, global::ScheduleOne.Persistence.CartelRegionalActivityData[] regionalActivityData, global::ScheduleOne.Cartel.CartelDealInfo activeCartelDeal, int hoursUntilNextDealRequest)
		{
		}
	}
}
