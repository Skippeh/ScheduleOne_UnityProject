namespace ScheduleOne.UI.Tooltips
{
	public class TooltipManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Tooltips.TooltipManager>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.RectTransform anchor;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TextMeshProUGUI tooltipLabel;

		[global::UnityEngine.Header("Canvas")]
		public global::System.Collections.Generic.List<global::UnityEngine.Canvas> canvases;

		private global::System.Collections.Generic.List<global::UnityEngine.Canvas> sortedCanvases;

		private global::System.Collections.Generic.List<global::UnityEngine.UI.GraphicRaycaster> raycasters;

		private global::UnityEngine.EventSystems.EventSystem eventSystem;

		private bool tooltipShownThisFrame;

		private global::UnityEngine.EventSystems.PointerEventData pointerEventData;

		private global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> rayResults;

		protected override void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void AddCanvas(global::UnityEngine.Canvas canvas)
		{
		}

		private void CheckForTooltipHover()
		{
		}

		public void ShowTooltip(string text, global::UnityEngine.Vector2 position, bool worldspace)
		{
		}
	}
}
