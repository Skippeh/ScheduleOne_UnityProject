using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	public class LabOvenCanvas : Singleton<LabOvenCanvas>
	{
		[Header("References")]
		public Canvas Canvas;

		public GameObject Container;

		public ItemSlotUI IngredientSlotUI;

		public ItemSlotUI OutputSlotUI;

		public TextMeshProUGUI InstructionLabel;

		public TextMeshProUGUI ErrorLabel;

		public Button BeginButton;

		public TextMeshProUGUI BeginButtonLabel;

		public RectTransform ProgressContainer;

		public Image IngredientIcon;

		public Image ProgressImg;

		public Image ProductIcon;

		public bool isOpen { get; protected set; }

		public LabOven Oven { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void SetIsOpen(LabOven oven, bool open, bool removeUI = true)
		{
		}

		public void BeginButtonPressed()
		{
		}

		public bool CanBegin()
		{
			return false;
		}

		private bool DoesOvenOutputHaveSpace()
		{
			return false;
		}

		private void RefreshActiveOperation()
		{
		}
	}
}
