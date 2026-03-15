namespace ScheduleOne.UI
{
	public class ItemSlotUI : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Color32 normalColor;

		public global::UnityEngine.Color32 highlightColor;

		[global::UnityEngine.HideInInspector]
		public bool IsBeingDragged;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private bool _playBopAnimation;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Rect;

		public global::UnityEngine.UI.Image Background;

		public global::UnityEngine.GameObject LockContainer;

		public global::UnityEngine.RectTransform ItemContainer;

		public global::ScheduleOne.UI.Items.ItemSlotFilterButton FilterButton;

		public global::UnityEngine.Animation BopAnimation;

		[global::UnityEngine.Header("Controller Support")]
		public global::ScheduleOne.UITrigger CmdQuickMove;

		public global::ScheduleOne.UITrigger CmdGrabAll;

		public global::ScheduleOne.UITrigger CmdQtyAdd;

		public global::ScheduleOne.UITrigger CmdQtySubtract;

		public global::ScheduleOne.UITrigger CmdToggleTooltip;

		public global::ScheduleOne.UITrigger CmdDiscardItem;

		private int _lastQuantity;

		private bool _slotBopQueued;

		public global::ScheduleOne.ItemFramework.ItemSlot assignedSlot { get; protected set; }

		public global::ScheduleOne.UI.Items.ItemUI ItemUI { get; protected set; }

		private void Awake()
		{
		}

		public virtual void AssignSlot(global::ScheduleOne.ItemFramework.ItemSlot s)
		{
		}

		public virtual void ClearSlot()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void OnDestroy()
		{
		}

		public virtual void UpdateUI()
		{
		}

		public void SetHighlighted(bool h)
		{
		}

		public void SetNormalColor(global::UnityEngine.Color color)
		{
		}

		public void SetHighlightColor(global::UnityEngine.Color color)
		{
		}

		private void Lock()
		{
		}

		private void Unlock()
		{
		}

		public void SetLockVisible(bool vis)
		{
		}

		public global::UnityEngine.RectTransform DuplicateIcon(global::UnityEngine.Transform parent, int overriddenQuantity = -1)
		{
			return null;
		}

		public void SetVisible(bool shown)
		{
		}

		public void OverrideDisplayedQuantity(int quantity)
		{
		}

		private void AssignControllerCommands()
		{
		}

		private void UnassignControllerCommands()
		{
		}

		private void WrapCmdQuickMove()
		{
		}

		private void WrapCmdGrabAll()
		{
		}

		private void WrapCmdQtyAdd()
		{
		}

		private void WrapCmdQtySubtract()
		{
		}

		private void WrapCmdToggleTooltip()
		{
		}

		private void WrapCmdDiscardItem()
		{
		}

		public void ControllerSelect(bool isSelected)
		{
		}

		private void OnItemSlotDataChanged()
		{
		}

		private void CheckSlotBop()
		{
		}
	}
}
