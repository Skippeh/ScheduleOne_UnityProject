namespace ScheduleOne.UI
{
	public class MouseTooltip : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.MouseTooltip>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform IconRect;

		public global::UnityEngine.UI.Image IconImg;

		public global::UnityEngine.RectTransform TooltipRect;

		public global::TMPro.TextMeshProUGUI TooltipLabel;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Vector3 TooltipOffset_NoIcon;

		public global::UnityEngine.Vector3 TooltipOffset_WithIcon;

		public global::UnityEngine.Vector3 IconOffset;

		[global::UnityEngine.Header("Colors")]
		public global::UnityEngine.Color Color_Invalid;

		[global::UnityEngine.Header("Sprites")]
		public global::UnityEngine.Sprite Sprite_Cross;

		private bool tooltipShownThisFrame;

		private bool iconShownThisFrame;

		public void ShowTooltip(string text, global::UnityEngine.Color col)
		{
		}

		public void ShowIcon(global::UnityEngine.Sprite sprite, global::UnityEngine.Color col)
		{
		}

		private void LateUpdate()
		{
		}
	}
}
