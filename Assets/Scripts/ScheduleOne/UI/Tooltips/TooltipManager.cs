using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Tooltips
{
	public class TooltipManager : Singleton<TooltipManager>
	{
		[Header("References")]
		[SerializeField]
		private RectTransform anchor;

		[SerializeField]
		private TextMeshProUGUI tooltipLabel;

		[Header("Canvas")]
		public List<Canvas> canvases;

		private List<Canvas> sortedCanvases;

		private List<GraphicRaycaster> raycasters;

		private EventSystem eventSystem;

		private bool tooltipShownThisFrame;

		protected override void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void AddCanvas(Canvas canvas)
		{
		}

		private void CheckForTooltipHover()
		{
		}

		public void ShowTooltip(string text, Vector2 position, bool worldspace)
		{
		}
	}
}
