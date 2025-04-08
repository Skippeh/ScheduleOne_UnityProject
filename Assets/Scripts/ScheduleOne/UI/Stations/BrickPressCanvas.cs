namespace ScheduleOne.UI.Stations
{
	public class BrickPressCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Stations.BrickPressCanvas>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::ScheduleOne.UI.ItemSlotUI[] ProductSlotUIs;

		public global::ScheduleOne.UI.ItemSlotUI OutputSlotUI;

		public global::TMPro.TextMeshProUGUI InstructionLabel;

		public global::UnityEngine.UI.Button BeginButton;

		public bool isOpen { get; protected set; }

		public global::ScheduleOne.ObjectScripts.BrickPress Press { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void SetIsOpen(global::ScheduleOne.ObjectScripts.BrickPress press, bool open, bool removeUI = true)
		{
		}

		public void BeginButtonPressed()
		{
		}
	}
}
