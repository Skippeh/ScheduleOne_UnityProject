namespace ScheduleOne.UI.Management
{
	public class RouteEntryUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Image SourceIcon;

		public global::TMPro.TextMeshProUGUI SourceLabel;

		public global::UnityEngine.UI.Image DestinationIcon;

		public global::TMPro.TextMeshProUGUI DestinationLabel;

		public global::UnityEngine.UI.Image FilterIcon;

		public global::UnityEngine.Events.UnityEvent onDeleteClicked;

		private bool settingSource;

		private bool settingDestination;

		public global::ScheduleOne.Management.AdvancedTransitRoute AssignedRoute { get; private set; }

		public void AssignRoute(global::ScheduleOne.Management.AdvancedTransitRoute route)
		{
		}

		public void ClearRoute()
		{
		}

		public void RefreshUI()
		{
		}

		public void SourceClicked()
		{
		}

		public void DestinationClicked()
		{
		}

		public void FilterClicked()
		{
		}

		public void DeleteClicked()
		{
		}

		private bool ObjectValid(global::ScheduleOne.Management.ITransitEntity obj, out string reason)
		{
			reason = null;
			return false;
		}

		public void ObjectsSelected(global::System.Collections.Generic.List<global::ScheduleOne.Management.ITransitEntity> objs)
		{
		}
	}
}
