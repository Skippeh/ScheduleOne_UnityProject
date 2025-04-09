using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	public class ItemUIManager : Singleton<ItemUIManager>
	{
		[Header("References")]
		public Canvas Canvas;

		public GraphicRaycaster[] Raycasters;

		public RectTransform CashDragAmountContainer;

		public RectTransform InputsContainer;

		public ItemInfoPanel InfoPanel;

		public RectTransform ItemQuantityPrompt;

		public Animation CashSlotHintAnim;

		public CanvasGroup CashSlotHintAnimCanvasGroup;

		[Header("Prefabs")]
		public ItemSlotUI ItemSlotUIPrefab;

		public ItemUI DefaultItemUIPrefab;

		public ItemSlotUI HotbarSlotUIPrefab;

		private ItemSlotUI draggedSlot;

		private Vector2 mouseOffset;

		private int draggedAmount;

		private RectTransform tempIcon;

		private bool isDraggingCash;

		private float draggedCashAmount;

		private List<ItemSlot> PrimarySlots;

		private List<ItemSlot> SecondarySlots;

		private bool customDragAmount;

		private Coroutine quantityChangePopRoutine;

		public UnityEvent onDragStart;

		public UnityEvent onItemMoved;

		public bool DraggingEnabled { get; protected set; }

		public ItemSlotUI HoveredSlot { get; protected set; }

		public bool QuickMoveEnabled { get; protected set; }

		protected override void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void UpdateCashDragSelectorUI()
		{
		}

		private void UpdateCashDragAmount(CashInstance instance)
		{
		}

		public void SetDraggingEnabled(bool enabled, bool modifierPromptsVisible = true)
		{
		}

		public void EnableQuickMove(List<ItemSlot> primarySlots, List<ItemSlot> secondarySlots)
		{
		}

		private List<ItemSlot> GetQuickMoveSlots(ItemSlot sourceSlot)
		{
			return null;
		}

		public void DisableQuickMove()
		{
		}

		private ItemSlotUI GetHoveredItemSlot()
		{
			return null;
		}

		private ItemDefinitionInfoHoverable GetHoveredItemInfo()
		{
			return null;
		}

		private void SlotClicked(ItemSlotUI ui)
		{
		}

		private void StartDragCash()
		{
		}

		private void EndDrag()
		{
		}

		private void SetDraggedAmount(int amount)
		{
		}

		private void EndCashDrag()
		{
		}

		public bool CanDragFromSlot(ItemSlotUI slotUI)
		{
			return false;
		}

		public bool CanCashBeDraggedIntoSlot(ItemSlotUI ui)
		{
			return false;
		}
	}
}
