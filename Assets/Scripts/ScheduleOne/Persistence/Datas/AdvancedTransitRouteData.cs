using System;
using System.Collections.Generic;
using ScheduleOne.Management;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class AdvancedTransitRouteData
	{
		public string SourceGUID;

		public string DestinationGUID;

		public ManagementItemFilter.EMode FilterMode;

		public List<string> FilterItemIDs;

		public AdvancedTransitRouteData(string sourceGUID, string destinationGUID, ManagementItemFilter.EMode filtermode, List<string> filterGUIDs)
		{
		}

		public AdvancedTransitRouteData()
		{
		}
	}
}
