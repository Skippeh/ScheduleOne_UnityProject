namespace ScheduleOne.UI.Management
{
	public class RouteListFieldUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public string FieldText;

		public global::TMPro.TextMeshProUGUI FieldLabel;

		public global::ScheduleOne.UI.Management.RouteEntryUI[] RouteEntries;

		public global::UnityEngine.RectTransform MultiEditBlocker;

		public global::UnityEngine.UI.Button AddButton;

		public global::System.Collections.Generic.List<global::ScheduleOne.Management.RouteListField> Fields { get; protected set; }

		private void Start()
		{
		}

		public void Bind(global::System.Collections.Generic.List<global::ScheduleOne.Management.RouteListField> field)
		{
		}

		private void Refresh(global::System.Collections.Generic.List<global::ScheduleOne.Management.AdvancedTransitRoute> newVal)
		{
		}

		private void EntryDeleteClicked(global::ScheduleOne.UI.Management.RouteEntryUI entry)
		{
		}

		private void AddClicked()
		{
		}

		private void RouteChanged(global::ScheduleOne.Management.ITransitEntity newEntity)
		{
		}
	}
}
