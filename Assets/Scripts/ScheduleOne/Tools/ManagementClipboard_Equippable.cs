namespace ScheduleOne.Tools
{
	public class ManagementClipboard_Equippable : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform Clipboard;

		public global::UnityEngine.Transform LoweredPosition;

		public global::UnityEngine.Transform RaisedPosition;

		public global::ScheduleOne.Misc.ToggleableLight Light;

		public global::ScheduleOne.UI.Management.SelectionInfoUI SelectionInfo;

		public global::TMPro.TextMeshProUGUI OverrideText;

		private static bool _heatmapToggledOn;

		private global::ScheduleOne.Property.Property _propertyWithHeatmapShown;

		private static bool _canToggleHeatmap => false;

		public static bool ResetHeatmapToggle()
		{
			return false;
		}

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		private void ShowInputPrompts()
		{
		}

		private void HideInputPrompts()
		{
		}

		public override void Unequip()
		{
		}

		protected override void Update()
		{
		}

		private bool CanToggleClipboard()
		{
			return false;
		}

		private void UpdateHeatmap()
		{
		}

		private void ClearPropertyWithHeatmapShown()
		{
		}

		private void FullscreenEnter()
		{
		}

		private void FullscreenExit()
		{
		}

		public void OverrideClipboardText(string overriddenText)
		{
		}

		public void EndOverride()
		{
		}
	}
}
