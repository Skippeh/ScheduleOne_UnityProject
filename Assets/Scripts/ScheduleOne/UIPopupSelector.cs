namespace ScheduleOne
{
	public class UIPopupSelector : global::ScheduleOne.UIOption
	{
		[global::UnityEngine.SerializeField]
		private global::TMPro.TextMeshProUGUI currentOptionNameText;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.UIPopupScreen_ContextMenu.ContextMenuOption> OnChanged;

		private global::ScheduleOne.UIPopupScreen_ContextMenu.ContextMenuOption[] options;

		private int currentIndex;

		public int GetOptionCount()
		{
			return 0;
		}

		protected override void Awake()
		{
		}

		private void OpenPopup()
		{
		}

		private void ClosePopup(int selectedIndex)
		{
		}

		public void SetCurrentOptionWithoutNotify(int index)
		{
		}

		private void UpdateCurrentOptionText()
		{
		}

		public void AddOption(global::ScheduleOne.UIPopupScreen_ContextMenu.ContextMenuOption option)
		{
		}

		public void AddOptions(global::ScheduleOne.UIPopupScreen_ContextMenu.ContextMenuOption[] newOptions)
		{
		}

		public void ClearOptions()
		{
		}

		private void ClampCurrentIndex()
		{
		}

		public void SetOptions(global::ScheduleOne.UIPopupScreen_ContextMenu.ContextMenuOption[] newOptions, int defaultIndex = 0)
		{
		}
	}
}
