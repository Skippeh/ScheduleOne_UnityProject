namespace ScheduleOne.UI.Stations
{
	public class CauldronCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Stations.CauldronCanvas>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.GameObject Container;

		public global::System.Collections.Generic.List<global::ScheduleOne.UI.ItemSlotUI> IngredientSlotUIs;

		public global::ScheduleOne.UI.ItemSlotUI LiquidSlotUI;

		public global::ScheduleOne.UI.ItemSlotUI OutputSlotUI;

		public global::TMPro.TextMeshProUGUI InstructionLabel;

		public global::UnityEngine.UI.Button BeginButton;

		public bool isOpen { get; protected set; }

		public global::ScheduleOne.ObjectScripts.Cauldron Cauldron { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void SetIsOpen(global::ScheduleOne.ObjectScripts.Cauldron cauldron, bool open, bool removeUI = true)
		{
		}

		public void BeginButtonPressed()
		{
		}
	}
}
