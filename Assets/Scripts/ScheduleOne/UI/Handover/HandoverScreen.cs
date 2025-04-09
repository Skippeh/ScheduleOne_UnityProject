using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Quests;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Handover
{
	public class HandoverScreen : Singleton<HandoverScreen>
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

		[Header("Settings")]
		public Gradient SuccessColorMap;

		[Header("References")]
		public Canvas Canvas;

		public GameObject Container;

		public CanvasGroup CanvasGroup;

		public TextMeshProUGUI DescriptionLabel;

		public TextMeshProUGUI CustomerSubtitle;

		public TextMeshProUGUI FavouriteDrugLabel;

		public TextMeshProUGUI FavouritePropertiesLabel;

		public TextMeshProUGUI[] PropertiesEntries;

		public RectTransform[] ExpectationEntries;

		public GameObject NoVehicle;

		public RectTransform VehicleSlotContainer;

		public RectTransform CustomerSlotContainer;

		public TextMeshProUGUI VehicleSubtitle;

		public TextMeshProUGUI SuccessLabel;

		public TextMeshProUGUI ErrorLabel;

		public TextMeshProUGUI WarningLabel;

		public Button DoneButton;

		public RectTransform VehicleContainer;

		public TextMeshProUGUI TitleLabel;

		public HandoverScreenPriceSelector PriceSelector;

		public TextMeshProUGUI FairPriceLabel;

		public Animation TutorialAnimation;

		public RectTransform TutorialContainer;

		public HandoverScreenDetailPanel DetailPanel;

		public Action<EHandoverOutcome, List<ItemInstance>, float> onHandoverComplete;

		public Func<List<ItemInstance>, float, float> SuccessChanceMethod;

		private ItemSlotUI[] VehicleSlotUIs;

		private ItemSlotUI[] CustomerSlotUIs;

		private ItemSlot[] CustomerSlots;

		private Dictionary<ItemInstance, EItemSource> OriginalItemLocations;

		private bool ignoreCustomerChangedEvents;

		public Contract CurrentContract { get; protected set; }

		public bool IsOpen { get; protected set; }

		public bool TutorialOpen { get; private set; }

		public EMode Mode { get; protected set; }

		public Customer CurrentCustomer { get; private set; }

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

		public virtual void Open(Contract contract, Customer customer, EMode mode, Action<EHandoverOutcome, List<ItemInstance>, float> callback, Func<List<ItemInstance>, float, float> successChanceMethod)
		{
		}

		public virtual void Close(EHandoverOutcome outcome)
		{
		}

		public void DonePressed()
		{
		}

		private void RecordOriginalLocations()
		{
		}

		private void Exit(ExitAction action)
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

		private List<ItemInstance> GetCustomerItems(bool onlyPackagedProduct = true)
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
