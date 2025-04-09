using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class MouseTooltip : Singleton<MouseTooltip>
	{
		[Header("References")]
		public RectTransform IconRect;

		public Image IconImg;

		public RectTransform TooltipRect;

		public TextMeshProUGUI TooltipLabel;

		[Header("Settings")]
		public Vector3 TooltipOffset_NoIcon;

		public Vector3 TooltipOffset_WithIcon;

		public Vector3 IconOffset;

		[Header("Colors")]
		public Color Color_Invalid;

		[Header("Sprites")]
		public Sprite Sprite_Cross;

		private bool tooltipShownThisFrame;

		private bool iconShownThisFrame;

		public void ShowTooltip(string text, Color col)
		{
		}

		public void ShowIcon(Sprite sprite, Color col)
		{
		}

		private void LateUpdate()
		{
		}
	}
}
