namespace ScheduleOne.UI.Stations
{
	public class DryingRackCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Stations.DryingRackCanvas>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::ScheduleOne.UI.ItemSlotUI InputSlotUI;

		public global::ScheduleOne.UI.ItemSlotUI OutputSlotUI;

		public global::TMPro.TextMeshProUGUI InstructionLabel;

		public global::TMPro.TextMeshProUGUI CapacityLabel;

		public global::UnityEngine.UI.Button InsertButton;

		public global::UnityEngine.RectTransform IndicatorContainer;

		public global::UnityEngine.RectTransform[] IndicatorAlignments;

		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.UI.Stations.Drying_rack.DryingOperationUI IndicatorPrefab;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Stations.Drying_rack.DryingOperationUI> operationUIs;

		public bool isOpen { get; protected set; }

		public global::ScheduleOne.ObjectScripts.DryingRack Rack { get; protected set; }

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

		public void SetIsOpen(global::ScheduleOne.ObjectScripts.DryingRack rack, bool open)
		{
		}

		private void CreateOperationUI(global::ScheduleOne.ObjectScripts.DryingOperation operation)
		{
		}

		private void DestroyOperationUI(global::ScheduleOne.ObjectScripts.DryingOperation operation)
		{
		}

		public void Insert()
		{
		}
	}
}
