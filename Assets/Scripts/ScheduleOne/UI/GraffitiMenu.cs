namespace ScheduleOne.UI
{
	public class GraffitiMenu : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.GraffitiMenu>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform ColorButtonContainer;

		public global::UnityEngine.UI.Button ClearButton;

		public global::UnityEngine.Transform ConfirmPanel;

		public global::UnityEngine.UI.Button ConfirmButton;

		public global::UnityEngine.UI.Button CancelButton;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject ColorButtonPrefab;

		public global::System.Action<global::ScheduleOne.Graffiti.ESprayColor> onColorSelected;

		public global::System.Action onClearClicked;

		public global::System.Action onConfirmClicked;

		private global::System.Collections.Generic.List<global::UnityEngine.UI.Button> colorButtons;

		protected override void Awake()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void ShowConfirmPanel()
		{
		}

		private void SelectColor(global::ScheduleOne.Graffiti.ESprayColor color)
		{
		}

		private void ClearClicked()
		{
		}

		private void ConfirmClicked()
		{
		}

		private void CancelClicked()
		{
		}
	}
}
