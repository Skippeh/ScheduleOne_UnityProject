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

		private global::UnityEngine.Coroutine moveRoutine;

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		protected override void Update()
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
