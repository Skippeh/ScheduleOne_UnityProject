namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class AdvancedTransitRouteData
	{
		public string SourceGUID;

		public string DestinationGUID;

		public global::ScheduleOne.Management.ManagementItemFilter.EMode FilterMode;

		public global::System.Collections.Generic.List<string> FilterItemIDs;

		public AdvancedTransitRouteData(string sourceGUID, string destinationGUID, global::ScheduleOne.Management.ManagementItemFilter.EMode filtermode, global::System.Collections.Generic.List<string> filterGUIDs)
		{
		}

		public AdvancedTransitRouteData()
		{
		}
	}
}
