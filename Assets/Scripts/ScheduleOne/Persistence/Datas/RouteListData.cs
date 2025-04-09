using System;
using System.Collections.Generic;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class RouteListData
	{
		public List<AdvancedTransitRouteData> Routes;

		public RouteListData(List<AdvancedTransitRouteData> routes)
		{
		}
	}
}
