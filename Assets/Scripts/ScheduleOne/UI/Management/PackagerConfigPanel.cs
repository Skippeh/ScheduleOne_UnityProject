using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class PackagerConfigPanel : ConfigPanel
	{
		[Header("References")]
		public ObjectFieldUI BedUI;

		public ObjectListFieldUI StationsUI;

		public RouteListFieldUI RoutesUI;

		public override void Bind(List<EntityConfiguration> configs)
		{
		}
	}
}
