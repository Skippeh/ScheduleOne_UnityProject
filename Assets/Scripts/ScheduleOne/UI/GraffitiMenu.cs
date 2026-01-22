namespace ScheduleOne.UI
{
	public class GraffitiMenu : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.GraffitiMenu>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform ColorButtonContainer;

		public global::UnityEngine.UI.Button ClearButton;

		public global::UnityEngine.UI.Button DoneButton;

		public global::UnityEngine.Transform ConfirmPanel;

		public global::UnityEngine.UI.Button ConfirmButton;

		public global::UnityEngine.UI.Button CancelButton;

		public global::UnityEngine.UI.Button UndoButton;

		public global::UnityEngine.RectTransform RemainigPaintContainer;

		public global::UnityEngine.UI.Slider RemainingPaintSlider;

		public global::UnityEngine.UI.Image[] RemainingPaintImages;

		public global::TMPro.TextMeshProUGUI RemainingPaintLabel;

		public global::UnityEngine.UI.Button[] WeightButtons;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject ColorButtonPrefab;

		public global::System.Action<global::ScheduleOne.Graffiti.ESprayColor> onColorSelected;

		public global::System.Action<byte> onWeightSelected;

		public global::System.Action onClearClicked;

		public global::System.Action onDone;

		public global::System.Action onUndoClicked;

		private global::System.Collections.Generic.List<global::UnityEngine.UI.Button> colorButtons;

		private global::ScheduleOne.Graffiti.SpraySurface activeSurface;

		protected override void Awake()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void Update()
		{
		}

		public void ShowConfirmPanel()
		{
		}

		private void SelectColor(global::ScheduleOne.Graffiti.ESprayColor color)
		{
		}

		private void WeightButtonClicked(int buttonIndex)
		{
		}

		public void UpdateRemainingPaintIndicator(float remainingPaint)
		{
		}

		private void ClearClicked()
		{
		}

		private void UndoClicked()
		{
		}

		private void Done()
		{
		}

		private void CancelClicked()
		{
		}

		public void SetActiveSurface(global::ScheduleOne.Graffiti.SpraySurface surface)
		{
		}

		public void ClearActiveSurface()
		{
		}

		private void UpdateUndoInteraction()
		{
		}
	}
}
