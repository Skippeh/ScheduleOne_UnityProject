namespace ScheduleOne.UI.Handover
{
	public class HandoverScreen : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Handover.HandoverScreen>
	{
		public enum EMode
		{
			Contract = 0,
			Sample = 1,
			Offer = 2
		}

		public enum EHandoverOutcome
		{
			Cancelled = 0,
			Finalize = 1
		}

		private enum EItemSource
		{
			Player = 0,
			Vehicle = 1
		}

		public const int CUSTOMER_SLOT_COUNT = 4;

		public const float VEHICLE_MAX_DIST = 20f;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Gradient SuccessColorMap;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.GameObject Container;

		public global::UnityEngine.CanvasGroup CanvasGroup;

		public global::TMPro.TextMeshProUGUI DescriptionLabel;

		public global::TMPro.TextMeshProUGUI CustomerSubtitle;

		public global::TMPro.TextMeshProUGUI FavouriteDrugLabel;

		public global::TMPro.TextMeshProUGUI FavouritePropertiesLabel;

		public global::TMPro.TextMeshProUGUI[] PropertiesEntries;

		public global::UnityEngine.RectTransform[] ExpectationEntries;

		public global::UnityEngine.GameObject NoVehicle;

		public global::UnityEngine.RectTransform VehicleSlotContainer;

		public global::UnityEngine.RectTransform CustomerSlotContainer;

		public global::TMPro.TextMeshProUGUI VehicleSubtitle;

		public global::TMPro.TextMeshProUGUI SuccessLabel;

		public global::TMPro.TextMeshProUGUI ErrorLabel;

		public global::TMPro.TextMeshProUGUI WarningLabel;

		public global::UnityEngine.UI.Button DoneButton;

		public global::UnityEngine.RectTransform VehicleContainer;

		public global::TMPro.TextMeshProUGUI TitleLabel;

		public global::ScheduleOne.UI.Handover.HandoverScreenPriceSelector PriceSelector;

		public global::TMPro.TextMeshProUGUI FairPriceLabel;

		public global::UnityEngine.Animation TutorialAnimation;

		public global::UnityEngine.RectTransform TutorialContainer;

		public global::ScheduleOne.UI.Handover.HandoverScreenDetailPanel DetailPanel;

		public global::System.Action<global::ScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance>, float> onHandoverComplete;

		public global::System.Func<global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance>, float, float> SuccessChanceMethod;

		private global::ScheduleOne.UI.ItemSlotUI[] VehicleSlotUIs;

		private global::ScheduleOne.UI.ItemSlotUI[] CustomerSlotUIs;

		private global::ScheduleOne.ItemFramework.ItemSlot[] CustomerSlots;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.ItemFramework.ItemInstance, global::ScheduleOne.UI.Handover.HandoverScreen.EItemSource> OriginalItemLocations;

		private bool ignoreCustomerChangedEvents;

		private bool requireFullChanceOfSuccess;

		public global::ScheduleOne.Quests.Contract CurrentContract { get; protected set; }

		public bool IsOpen { get; protected set; }

		public bool TutorialOpen { get; private set; }

		public global::ScheduleOne.UI.Handover.HandoverScreen.EMode Mode { get; protected set; }

		public global::ScheduleOne.Economy.Customer CurrentCustomer { get; private set; }

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		private void OpenTutorial()
		{
		}

		public void CloseTutorial()
		{
		}

		public virtual void Open(global::ScheduleOne.Quests.Contract contract, global::ScheduleOne.Economy.Customer customer, global::ScheduleOne.UI.Handover.HandoverScreen.EMode mode, global::System.Action<global::ScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance>, float> callback, global::System.Func<global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance>, float, float> successChanceMethod, bool _requireFullChanceOfSuccess = false)
		{
		}

		public virtual void Close(global::ScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome outcome)
		{
		}

		public void DonePressed()
		{
		}

		private void RecordOriginalLocations()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void ClearCustomerSlots(bool returnToOriginals)
		{
		}

		private void CustomerItemsChanged()
		{
		}

		private void UpdateDoneButton()
		{
		}

		private void UpdateSuccessChance()
		{
		}

		private bool GetError(out string err)
		{
			err = null;
			return false;
		}

		private bool GetWarning(out string warning)
		{
			warning = null;
			return false;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> GetCustomerItems(bool onlyPackagedProduct = true)
		{
			return null;
		}

		private float GetCustomerItemsValue()
		{
			return 0f;
		}

		private int GetCustomerItemsCount(bool onlyPackagedProduct = true)
		{
			return 0;
		}
	}
}
