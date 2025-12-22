namespace ScheduleOne.PlayerScripts
{
	public class PlayerInventory : global::ScheduleOne.DevUtilities.PlayerSingleton<global::ScheduleOne.PlayerScripts.PlayerInventory>
	{
		[global::System.Serializable]
		public class ItemVariable
		{
			public global::ScheduleOne.ItemFramework.ItemDefinition Definition;

			public string VariableName;
		}

		[global::System.Serializable]
		private class ItemAmount
		{
			public global::ScheduleOne.ItemFramework.ItemDefinition Definition;

			public int Amount;
		}

		public const float LABEL_DISPLAY_TIME = 2f;

		public const float LABEL_FADE_TIME = 0.5f;

		public const float DISCARD_TIME = 1.5f;

		public const int INVENTORY_SLOT_COUNT = 8;

		[global::UnityEngine.Header("Startup Items (Editor only)")]
		[global::UnityEngine.SerializeField]
		private bool giveStartupItems;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.PlayerInventory.ItemAmount> startupItems;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform equipContainer;

		public global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.HotbarSlot> hotbarSlots;

		private global::ScheduleOne.ItemFramework.ClipboardSlot clipboardSlot;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.ItemSlotUI> slotUIs;

		private global::ScheduleOne.ItemFramework.ItemSlot discardSlot;

		[global::UnityEngine.Header("Item Variables")]
		public global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.PlayerInventory.ItemVariable> ItemVariables;

		private int _equippedSlotIndex;

		public global::System.Action<bool> onInventoryStateChanged;

		public global::System.Action<int> onEquippedSlotChanged;

		private int PriorEquippedSlotIndex;

		private int PreviousEquippedSlotIndex;

		public global::UnityEngine.Events.UnityEvent onPreItemEquipped;

		public global::UnityEngine.Events.UnityEvent onItemEquipped;

		private bool ManagementSlotEnabled;

		public float currentEquipTime;

		protected float currentDiscardTime;

		public int TOTAL_SLOT_COUNT => 0;

		public global::ScheduleOne.Money.CashSlot cashSlot { get; private set; }

		public global::ScheduleOne.ItemFramework.CashInstance cashInstance { get; protected set; }

		public int EquippedSlotIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool HotbarEnabled { get; protected set; }

		public bool EquippingEnabled { get; protected set; }

		public global::ScheduleOne.Equipping.Equippable equippable { get; protected set; }

		public global::ScheduleOne.PlayerScripts.HotbarSlot equippedSlot => null;

		public global::ScheduleOne.ItemFramework.ItemInstance EquippedItem => null;

		public bool isAnythingEquipped => false;

		public global::ScheduleOne.PlayerScripts.HotbarSlot IndexAllSlots(int index)
		{
			return null;
		}

		protected override void Awake()
		{
		}

		private void SetupInventoryUI()
		{
		}

		private void RepositionUI()
		{
		}

		protected override void Start()
		{
		}

		private void GiveStartupItems()
		{
		}

		protected virtual void Update()
		{
		}

		private void UpdateHotbarSelection()
		{
		}

		public void Equip(global::ScheduleOne.PlayerScripts.HotbarSlot slot)
		{
		}

		public void SetInventoryEnabled(bool enabled)
		{
		}

		public void SetEquippingEnabled(bool enabled)
		{
		}

		private void ClipboardAcquiredVarChange(bool newVal)
		{
		}

		public void SetManagementClipboardEnabled(bool enabled)
		{
		}

		public void SetViewmodelVisible(bool visible)
		{
		}

		public bool CanItemFitInInventory(global::ScheduleOne.ItemFramework.ItemInstance item, int quantity = 1)
		{
			return false;
		}

		public void AddItemToInventory(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public uint GetAmountOfItem(string ID)
		{
			return 0u;
		}

		public void RemoveAmountOfItem(string ID, uint amount = 1u)
		{
		}

		public void ClearInventory()
		{
		}

		public void RemoveProductFromInventory(global::ScheduleOne.Product.Packaging.EStealthLevel maxStealth)
		{
		}

		public void RemoveRandomItemsFromInventory()
		{
		}

		public void SetEquippable(global::ScheduleOne.Equipping.Equippable eq)
		{
		}

		public void EquippedSlotChanged()
		{
		}

		public void Reequip()
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> GetAllInventorySlots()
		{
			return null;
		}

		private void UpdateInventoryVariables()
		{
		}
	}
}
