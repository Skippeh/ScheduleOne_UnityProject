using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class ChemistryStationConfigPanel : ConfigPanel
	{
		[Header("References")]
		public StationRecipeFieldUI RecipeUI;

		public ObjectFieldUI DestinationUI;

		public override void Bind(List<EntityConfiguration> configs)
		{
		}
	}
}
