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

		private int _lastQuantity;

		private bool _slotBopQueued;

		public global::ScheduleOne.ItemFramework.ItemSlot assignedSlot { get; protected set; }

		public global::ScheduleOne.UI.Items.ItemUI ItemUI { get; protected set; }

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

		private void OnItemSlotDataChanged()
		{
		}

		private void CheckSlotBop()
		{
		}
	}
}
