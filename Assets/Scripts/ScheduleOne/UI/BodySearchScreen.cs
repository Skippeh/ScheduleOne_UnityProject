namespace ScheduleOne.UI
{
	public class BodySearchScreen : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.BodySearchScreen>
	{
		public const float MAX_SPEED_BOOST = 2.5f;

		public global::UnityEngine.Color SlotRedColor;

		public global::UnityEngine.Color SlotHighlightRedColor;

		public float GapTime;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.RectTransform MinigameController;

		public global::UnityEngine.RectTransform SlotContainer;

		public global::ScheduleOne.UI.ItemSlotUI ItemSlotPrefab;

		public global::UnityEngine.RectTransform SearchIndicator;

		public global::UnityEngine.RectTransform SearchIndicatorStart;

		public global::UnityEngine.RectTransform SearchIndicatorEnd;

		public global::UnityEngine.Animation IndicatorAnimation;

		public global::UnityEngine.Animation TutorialAnimation;

		public global::UnityEngine.RectTransform TutorialContainer;

		public global::UnityEngine.Animation ResetAnimation;

		public global::ScheduleOne.Audio.AudioSourceController FailSound;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.ItemSlotUI> slots;

		public global::UnityEngine.Events.UnityEvent onSearchClear;

		public global::UnityEngine.Events.UnityEvent onSearchFail;

		private global::UnityEngine.Color defaultSlotColor;

		private global::UnityEngine.Color defaultSlotHighlightColor;

		private global::ScheduleOne.UI.ItemSlotUI concealedSlot;

		private global::ScheduleOne.UI.ItemSlotUI hoveredSlot;

		private global::UnityEngine.Color[] defaultItemIconColors;

		private float speedBoost;

		private global::ScheduleOne.NPCs.NPC searcher;

		private bool _caught;

		public bool IsOpen { get; private set; }

		public bool TutorialOpen { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void SetupSlots()
		{
		}

		private void Update()
		{
		}

		public void Open(global::ScheduleOne.NPCs.NPC _searcher, float searchTime = 0f)
		{
		}

		private bool IsSlotConcealed(global::ScheduleOne.UI.ItemSlotUI slot)
		{
			return false;
		}

		private void ItemDetected(global::ScheduleOne.UI.ItemSlotUI slot)
		{
		}

		public void SlotHeld(global::ScheduleOne.UI.ItemSlotUI ui)
		{
		}

		public void SlotReleased(global::ScheduleOne.UI.ItemSlotUI ui)
		{
		}

		public void Close(bool clear)
		{
		}

		private void OpenTutorial()
		{
		}

		public void CloseTutorial()
		{
		}
	}
}
