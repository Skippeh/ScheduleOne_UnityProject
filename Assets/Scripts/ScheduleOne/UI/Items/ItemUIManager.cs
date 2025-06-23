namespace ScheduleOne.UI.Items
{
	public class ItemUIManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Items.ItemUIManager>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.UI.GraphicRaycaster[] Raycasters;

		public global::UnityEngine.RectTransform CashDragAmountContainer;

		public global::UnityEngine.RectTransform InputsContainer;

		public global::ScheduleOne.UI.Items.ItemInfoPanel InfoPanel;

		public global::UnityEngine.RectTransform ItemQuantityPrompt;

		public global::UnityEngine.Animation CashSlotHintAnim;

		public global::UnityEngine.CanvasGroup CashSlotHintAnimCanvasGroup;

		public global::ScheduleOne.UI.Items.FilterConfigPanel FilterConfigPanel;

		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.UI.ItemSlotUI ItemSlotUIPrefab;

		public global::ScheduleOne.UI.Items.ItemUI DefaultItemUIPrefab;

		public global::ScheduleOne.UI.ItemSlotUI HotbarSlotUIPrefab;

		private global::ScheduleOne.UI.ItemSlotUI draggedSlot;

		private global::UnityEngine.Vector2 mouseOffset;

		private int draggedAmount;

		private global::UnityEngine.RectTransform tempIcon;

		private bool isDraggingCash;

		private float draggedCashAmount;

		private global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> PrimarySlots;

		private global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> SecondarySlots;

		private bool customDragAmount;

		private global::UnityEngine.Coroutine quantityChangePopRoutine;

		public global::UnityEngine.Events.UnityEvent onDragStart;

		public global::UnityEngine.Events.UnityEvent onItemMoved;

		public bool DraggingEnabled { get; protected set; }

		public global::ScheduleOne.UI.ItemSlotUI HoveredSlot { get; protected set; }

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

		private void UpdateCashDragAmount(global::ScheduleOne.ItemFramework.CashInstance instance)
		{
		}

		public void SetDraggingEnabled(bool enabled, bool modifierPromptsVisible = true)
		{
		}

		public void EnableQuickMove(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> primarySlots, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> secondarySlots)
		{
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> GetQuickMoveSlots(global::ScheduleOne.ItemFramework.ItemSlot sourceSlot)
		{
			return null;
		}

		public void DisableQuickMove()
		{
		}

		private global::ScheduleOne.UI.ItemSlotUI GetHoveredItemSlot()
		{
			return null;
		}

		private global::ScheduleOne.UI.Items.ItemDefinitionInfoHoverable GetHoveredItemInfo()
		{
			return null;
		}

		private void SlotClicked(global::ScheduleOne.UI.ItemSlotUI ui)
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

		public bool CanDragFromSlot(global::ScheduleOne.UI.ItemSlotUI slotUI)
		{
			return false;
		}

		public bool CanCashBeDraggedIntoSlot(global::ScheduleOne.UI.ItemSlotUI ui)
		{
			return false;
		}
	}
}
