using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class PackagerConfigurationData : SaveData
	{
		public ObjectFieldData Bed;

		public ObjectListFieldData Stations;

		public RouteListData Routes;

		public PackagerConfigurationData(ObjectFieldData bed, ObjectListFieldData stations, RouteListData routes)
		{
		}
	}
}
