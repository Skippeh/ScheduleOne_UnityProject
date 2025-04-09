using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class PotConfigPanel : ConfigPanel
	{
		[Header("References")]
		public ItemFieldUI SeedUI;

		public ItemFieldUI Additive1UI;

		public ItemFieldUI Additive2UI;

		public ItemFieldUI Additive3UI;

		public ObjectFieldUI DestinationUI;

		public override void Bind(List<EntityConfiguration> configs)
		{
		}
	}
}
