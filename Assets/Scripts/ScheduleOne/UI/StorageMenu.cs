namespace ScheduleOne.UI
{
	public class StorageMenu : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.StorageMenu>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::TMPro.TextMeshProUGUI TitleLabel;

		public global::TMPro.TextMeshProUGUI SubtitleLabel;

		public global::UnityEngine.RectTransform SlotContainer;

		public global::ScheduleOne.UI.ItemSlotUI[] SlotsUIs;

		public global::UnityEngine.UI.GridLayoutGroup SlotGridLayout;

		public global::UnityEngine.RectTransform CloseButton;

		public global::UnityEngine.Events.UnityEvent onClosed;

		public bool IsOpen { get; protected set; }

		public global::ScheduleOne.Storage.StorageEntity OpenedStorageEntity { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public virtual void Open(global::ScheduleOne.ItemFramework.IItemSlotOwner owner, string title, string subtitle)
		{
		}

		public virtual void Open(global::ScheduleOne.Storage.StorageEntity entity)
		{
		}

		private void Open(string title, string subtitle, global::ScheduleOne.ItemFramework.IItemSlotOwner owner)
		{
		}

		public void Close()
		{
		}

		public virtual void CloseMenu()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}
	}
}
