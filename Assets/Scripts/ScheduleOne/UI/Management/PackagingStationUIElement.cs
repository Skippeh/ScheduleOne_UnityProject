namespace ScheduleOne.UI.Management
{
	public class PackagingStationUIElement : global::ScheduleOne.UI.Management.WorldspaceUIElement
	{
		public global::ScheduleOne.ObjectScripts.PackagingStation AssignedStation { get; protected set; }

		public void Initialize(global::ScheduleOne.ObjectScripts.PackagingStation pack)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
