namespace ScheduleOne.UI.Management
{
	public class CleanerUIElement : global::ScheduleOne.UI.Management.WorldspaceUIElement
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Image[] StationsIcons;

		public global::ScheduleOne.Employees.Cleaner AssignedCleaner { get; protected set; }

		public void Initialize(global::ScheduleOne.Employees.Cleaner cleaner)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
