using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class StorageMenu : Singleton<StorageMenu>
	{
		[Header("References")]
		public Canvas Canvas;

		public RectTransform Container;

		public TextMeshProUGUI TitleLabel;

		public TextMeshProUGUI SubtitleLabel;

		public RectTransform SlotContainer;

		public ItemSlotUI[] SlotsUIs;

		public GridLayoutGroup SlotGridLayout;

		public RectTransform CloseButton;

		public UnityEvent onClosed;

		public bool IsOpen { get; protected set; }

		public StorageEntity OpenedStorageEntity { get; protected set; }

		protected override void Awake()
		{
		}

		public virtual void Open(IItemSlotOwner owner, string title, string subtitle)
		{
		}

		public virtual void Open(StorageEntity entity)
		{
		}

		private void Open(string title, string subtitle, IItemSlotOwner owner)
		{
		}

		public void Close()
		{
		}

		public virtual void CloseMenu()
		{
		}

		private void Exit(ExitAction action)
		{
		}
	}
}
