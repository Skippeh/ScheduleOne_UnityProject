namespace ScheduleOne.UI.Management
{
	public class DryingRackUIElement : global::ScheduleOne.UI.Management.WorldspaceUIElement
	{
		public global::UnityEngine.UI.Image TargetQualityIcon;

		public global::ScheduleOne.ObjectScripts.DryingRack AssignedRack { get; protected set; }

		public void Initialize(global::ScheduleOne.ObjectScripts.DryingRack rack)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
