using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class CleanerConfigPanel : ConfigPanel
	{
		[Header("References")]
		public ObjectFieldUI BedUI;

		public ObjectListFieldUI BinsUI;

		public override void Bind(List<EntityConfiguration> configs)
		{
		}
	}
}
