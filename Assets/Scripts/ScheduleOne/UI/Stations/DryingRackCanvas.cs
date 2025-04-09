using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using ScheduleOne.UI.Stations.Drying_rack;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	public class DryingRackCanvas : Singleton<DryingRackCanvas>
	{
		[Header("References")]
		public Canvas Canvas;

		public RectTransform Container;

		public ItemSlotUI InputSlotUI;

		public ItemSlotUI OutputSlotUI;

		public TextMeshProUGUI InstructionLabel;

		public TextMeshProUGUI CapacityLabel;

		public Button InsertButton;

		public RectTransform IndicatorContainer;

		public RectTransform[] IndicatorAlignments;

		[Header("Prefabs")]
		public DryingOperationUI IndicatorPrefab;

		private List<DryingOperationUI> operationUIs;

		public bool isOpen { get; protected set; }

		public DryingRack Rack { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void MinPass()
		{
		}

		protected virtual void Update()
		{
		}

		private void UpdateUI()
		{
		}

		private void UpdateDryingOperations()
		{
		}

		private void UpdateQuantities()
		{
		}

		public void SetIsOpen(DryingRack rack, bool open)
		{
		}

		private void CreateOperationUI(DryingOperation operation)
		{
		}

		private void DestroyOperationUI(DryingOperation operation)
		{
		}

		public void Insert()
		{
		}
	}
}
