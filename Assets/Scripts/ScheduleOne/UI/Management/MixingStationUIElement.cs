namespace ScheduleOne.UI.Management
{
	public class MixingStationUIElement : global::ScheduleOne.UI.Management.WorldspaceUIElement
	{
		public global::ScheduleOne.ObjectScripts.MixingStation AssignedStation { get; protected set; }

		public void Initialize(global::ScheduleOne.ObjectScripts.MixingStation station)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
