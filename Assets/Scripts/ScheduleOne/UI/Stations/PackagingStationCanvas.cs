namespace ScheduleOne.UI.Stations
{
	public class PackagingStationCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Stations.PackagingStationCanvas>
	{
		public bool ShowHintOnOpen;

		public bool ShowShiftClickHint;

		public global::ScheduleOne.ObjectScripts.PackagingStation.EMode CurrentMode;

		public global::UnityEngine.Color InstructionWarningColor;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.GameObject Container;

		public global::ScheduleOne.UI.ItemSlotUI PackagingSlotUI;

		public global::ScheduleOne.UI.ItemSlotUI ProductSlotUI;

		public global::ScheduleOne.UI.ItemSlotUI OutputSlotUI;

		public global::TMPro.TextMeshProUGUI InstructionLabel;

		public global::UnityEngine.UI.Image InstructionShadow;

		public global::UnityEngine.UI.Button BeginButton;

		public global::UnityEngine.Animation ModeAnimation;

		public global::TMPro.TextMeshProUGUI ButtonLabel;

		public bool isOpen { get; protected set; }

		public global::ScheduleOne.ObjectScripts.PackagingStation PackagingStation { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void SetIsOpen(global::ScheduleOne.ObjectScripts.PackagingStation station, bool open, bool removeUI = true)
		{
		}

		public void BeginButtonPressed()
		{
		}

		private void UpdateSlotPositions()
		{
		}

		public void ToggleMode()
		{
		}

		public void SetMode(global::ScheduleOne.ObjectScripts.PackagingStation.EMode mode)
		{
		}
	}
}
