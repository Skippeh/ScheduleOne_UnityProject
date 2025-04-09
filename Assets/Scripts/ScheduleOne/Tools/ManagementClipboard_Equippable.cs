using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Misc;
using ScheduleOne.UI.Management;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Tools
{
	public class ManagementClipboard_Equippable : Equippable_Viewmodel
	{
		[Header("References")]
		public Transform Clipboard;

		public Transform LoweredPosition;

		public Transform RaisedPosition;

		public ToggleableLight Light;

		public SelectionInfoUI SelectionInfo;

		public TextMeshProUGUI OverrideText;

		private Coroutine moveRoutine;

		public override void Equip(ItemInstance item)
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
