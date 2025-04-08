namespace ScheduleOne.UI.Management
{
	public class PackagerConfigPanel : global::ScheduleOne.Management.UI.ConfigPanel
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.UI.Management.ObjectFieldUI BedUI;

		public global::ScheduleOne.UI.Management.ObjectListFieldUI StationsUI;

		public global::ScheduleOne.UI.Management.RouteListFieldUI RoutesUI;

		public override void Bind(global::System.Collections.Generic.List<global::ScheduleOne.Management.EntityConfiguration> configs)
		{
		}
	}
}
