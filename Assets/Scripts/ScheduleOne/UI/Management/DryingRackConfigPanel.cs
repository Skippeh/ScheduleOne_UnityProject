using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class DryingRackConfigPanel : ConfigPanel
	{
		[Header("References")]
		public QualityFieldUI QualityUI;

		public ObjectFieldUI DestinationUI;

		public override void Bind(List<EntityConfiguration> configs)
		{
		}
	}
}
