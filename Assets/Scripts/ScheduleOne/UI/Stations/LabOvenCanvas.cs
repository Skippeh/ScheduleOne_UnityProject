namespace ScheduleOne.UI.Stations
{
	public class LabOvenCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Stations.LabOvenCanvas>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.GameObject Container;

		public global::ScheduleOne.UI.ItemSlotUI IngredientSlotUI;

		public global::ScheduleOne.UI.ItemSlotUI OutputSlotUI;

		public global::TMPro.TextMeshProUGUI InstructionLabel;

		public global::TMPro.TextMeshProUGUI ErrorLabel;

		public global::UnityEngine.UI.Button BeginButton;

		public global::TMPro.TextMeshProUGUI BeginButtonLabel;

		public global::UnityEngine.RectTransform ProgressContainer;

		public global::UnityEngine.UI.Image IngredientIcon;

		public global::UnityEngine.UI.Image ProgressImg;

		public global::UnityEngine.UI.Image ProductIcon;

		public bool isOpen { get; protected set; }

		public global::ScheduleOne.ObjectScripts.LabOven Oven { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void SetIsOpen(global::ScheduleOne.ObjectScripts.LabOven oven, bool open, bool removeUI = true)
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
