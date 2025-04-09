using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	public class PackagingStationCanvas : Singleton<PackagingStationCanvas>
	{
		public bool ShowHintOnOpen;

		public bool ShowShiftClickHint;

		public PackagingStation.EMode CurrentMode;

		public Color InstructionWarningColor;

		[Header("References")]
		public Canvas Canvas;

		public GameObject Container;

		public ItemSlotUI PackagingSlotUI;

		public ItemSlotUI ProductSlotUI;

		public ItemSlotUI OutputSlotUI;

		public TextMeshProUGUI InstructionLabel;

		public Image InstructionShadow;

		public Button BeginButton;

		public Animation ModeAnimation;

		public TextMeshProUGUI ButtonLabel;

		public bool isOpen { get; protected set; }

		public PackagingStation PackagingStation { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void SetIsOpen(PackagingStation station, bool open, bool removeUI = true)
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

		public void SetMode(PackagingStation.EMode mode)
		{
		}
	}
}
