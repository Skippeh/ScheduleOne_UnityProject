namespace ScheduleOne.UI
{
	public class VehicleModMenu : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.VehicleModMenu>
	{
		public static float repaintCost;

		[global::UnityEngine.Header("UI References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Canvas canvas;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform buttonContainer;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform tempIndicator;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform permIndicator;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button confirmButton_Online;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI confirmText_Online;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform CameraPosition;

		public global::UnityEngine.Transform VehiclePosition;

		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject buttonPrefab;

		public global::UnityEngine.Events.UnityEvent onPaintPurchased;

		protected global::ScheduleOne.Vehicles.LandVehicle currentVehicle;

		protected global::System.Collections.Generic.List<global::UnityEngine.RectTransform> colorButtons;

		protected global::System.Collections.Generic.Dictionary<global::ScheduleOne.Vehicles.Modification.EVehicleColor, global::UnityEngine.RectTransform> colorToButton;

		protected global::ScheduleOne.Vehicles.Modification.EVehicleColor selectedColor;

		private global::UnityEngine.Coroutine openCloseRoutine;

		public bool IsOpen { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		protected virtual void Update()
		{
		}

		public void Open(global::ScheduleOne.Vehicles.LandVehicle vehicle)
		{
		}

		public void Close()
		{
		}

		public void ColorClicked(global::ScheduleOne.Vehicles.Modification.EVehicleColor col)
		{
		}

		private void UpdateConfirmButton()
		{
		}

		private void RefreshSelectionIndicator()
		{
		}

		public void ConfirmButtonClicked()
		{
		}
	}
}
