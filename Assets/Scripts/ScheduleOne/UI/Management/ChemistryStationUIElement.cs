namespace ScheduleOne.UI.Management
{
	public class ChemistryStationUIElement : global::ScheduleOne.UI.Management.WorldspaceUIElement
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.UI.Stations.StationRecipeEntry RecipeEntry;

		public global::UnityEngine.GameObject NoRecipe;

		public global::ScheduleOne.ObjectScripts.ChemistryStation AssignedStation { get; protected set; }

		public void Initialize(global::ScheduleOne.ObjectScripts.ChemistryStation oven)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
