namespace ScheduleOne.UI.Management
{
	public class StationRecipeFieldUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.UI.Stations.StationRecipeEntry RecipeEntry;

		public global::UnityEngine.GameObject None;

		public global::UnityEngine.GameObject Mixed;

		public global::UnityEngine.GameObject ClearButton;

		public global::System.Collections.Generic.List<global::ScheduleOne.Management.StationRecipeField> Fields { get; protected set; }

		public void Bind(global::System.Collections.Generic.List<global::ScheduleOne.Management.StationRecipeField> field)
		{
		}

		private void Refresh(global::ScheduleOne.StationFramework.StationRecipe newVal)
		{
		}

		private bool AreFieldsUniform()
		{
			return false;
		}

		public void Clicked()
		{
		}

		private void OptionSelected(global::ScheduleOne.StationFramework.StationRecipe option)
		{
		}

		public void ClearClicked()
		{
		}
	}
}
