namespace ScheduleOne
{
	public class UIContentPanel : global::ScheduleOne.UIPanel
	{
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Default is ImmediateDirection. ImmediatelyDirection is suitable if selectables are placed in grid format. NearestDirectionAndDistance is suitable for non-grid format")]
		private global::ScheduleOne.UIPanel.UINavigationType uiPanelNavigationType;

		protected override void DetectInput()
		{
		}

		protected override bool Navigate(global::UnityEngine.Vector2 navDir)
		{
			return false;
		}
	}
}
