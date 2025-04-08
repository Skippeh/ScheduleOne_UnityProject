namespace ScheduleOne.UI.Management
{
	public class ChemistUIElement : global::ScheduleOne.UI.Management.WorldspaceUIElement
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Image[] StationsIcons;

		public global::ScheduleOne.Employees.Chemist AssignedChemist { get; protected set; }

		public void Initialize(global::ScheduleOne.Employees.Chemist chemist)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
