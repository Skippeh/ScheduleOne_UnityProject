namespace ScheduleOne.UI.Management
{
	public class DryingRackConfigPanel : global::ScheduleOne.Management.UI.ConfigPanel
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.UI.Management.QualityFieldUI QualityUI;

		public global::ScheduleOne.UI.Management.ObjectFieldUI DestinationUI;

		public global::ScheduleOne.UI.Management.NumberFieldUI StartThresholdUI;

		public override void Bind(global::System.Collections.Generic.List<global::ScheduleOne.Management.EntityConfiguration> configs)
		{
		}
	}
}
