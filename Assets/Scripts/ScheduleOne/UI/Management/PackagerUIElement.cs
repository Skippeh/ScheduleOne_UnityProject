namespace ScheduleOne.UI.Management
{
	public class PackagerUIElement : global::ScheduleOne.UI.Management.WorldspaceUIElement
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform[] StationRects;

		public global::ScheduleOne.Employees.Packager AssignedPackager { get; protected set; }

		public void Initialize(global::ScheduleOne.Employees.Packager packager)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
