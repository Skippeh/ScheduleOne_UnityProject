using ScheduleOne.ItemFramework;
using ScheduleOne.UI.Items;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class ItemSlotUI : MonoBehaviour
	{
		public Color32 normalColor;

		public Color32 highlightColor;

		[HideInInspector]
		public bool IsBeingDragged;

		[Header("References")]
		public RectTransform Rect;

		public Image Background;

		public GameObject LockContainer;

		public RectTransform ItemContainer;

		public ItemSlot assignedSlot { get; protected set; }

		public ItemUI ItemUI { get; protected set; }

		public virtual void AssignSlot(ItemSlot s)
		{
		}

		public virtual void ClearSlot()
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

		public void SetNormalColor(Color color)
		{
		}

		public void SetHighlightColor(Color color)
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

		public RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			return null;
		}

		public void SetVisible(bool shown)
		{
		}

		public void OverrideDisplayedQuantity(int quantity)
		{
		}
	}
}
