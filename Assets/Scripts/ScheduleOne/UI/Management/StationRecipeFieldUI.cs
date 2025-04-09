using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Stations;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class StationRecipeFieldUI : MonoBehaviour
	{
		[Header("References")]
		public StationRecipeEntry RecipeEntry;

		public GameObject None;

		public GameObject Mixed;

		public GameObject ClearButton;

		public List<StationRecipeField> Fields { get; protected set; }

		public void Bind(List<StationRecipeField> field)
		{
		}

		private void Refresh(StationRecipe newVal)
		{
		}

		private bool AreFieldsUniform()
		{
			return false;
		}

		public void Clicked()
		{
		}

		private void OptionSelected(StationRecipe option)
		{
		}

		public void ClearClicked()
		{
		}
	}
}
