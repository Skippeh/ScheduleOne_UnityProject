using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class MixingStationConfigPanel : ConfigPanel
	{
		[Header("References")]
		public ObjectFieldUI DestinationUI;

		public NumberFieldUI StartThresholdUI;

		public override void Bind(List<EntityConfiguration> configs)
		{
		}
	}
}
