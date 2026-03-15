namespace ScheduleOne.UI.Management
{
	public class ChemistConfigPanel : global::ScheduleOne.Management.UI.ConfigPanel
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.UI.Management.ObjectFieldUI BedUI;

		public global::ScheduleOne.UI.Management.ObjectListFieldUI StationsUI;

		protected override void BindInternal(global::System.Collections.Generic.List<global::ScheduleOne.Management.EntityConfiguration> configs)
		{
		}
	}
}
