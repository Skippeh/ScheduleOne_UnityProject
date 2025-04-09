using ScheduleOne.ObjectScripts;

namespace ScheduleOne.UI.Management
{
	public class PackagingStationUIElement : WorldspaceUIElement
	{
		public PackagingStation AssignedStation { get; protected set; }

		public void Initialize(PackagingStation pack)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
