namespace ScheduleOne.UI
{
	public class PickpocketScreen : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.PickpocketScreen>
	{
		public const int PICKPOCKET_XP = 2;

		[global::UnityEngine.Header("Settings")]
		public float GreenAreaMaxWidth;

		public float GreenAreaMinWidth;

		public float SlideTime;

		public float SlideTimeMaxMultiplier;

		public float ValueDivisor;

		public float Tolerance;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::ScheduleOne.UI.ItemSlotUI[] Slots;

		public global::UnityEngine.RectTransform[] GreenAreas;

		public global::UnityEngine.Animation TutorialAnimation;

		public global::UnityEngine.RectTransform TutorialContainer;

		public global::UnityEngine.RectTransform SliderContainer;

		public global::UnityEngine.UI.Slider Slider;

		public global::ScheduleOne.UI.Input.InputPrompt InputPrompt;

		public global::UnityEngine.RectTransform ActionsContainer;

		public global::UnityEngine.Events.UnityEvent onFail;

		public global::UnityEngine.Events.UnityEvent onStop;

		public global::UnityEngine.Events.UnityEvent onHitGreen;

		private global::ScheduleOne.NPCs.NPC npc;

		private bool isSliding;

		private int slideDirection;

		private float sliderPosition;

		private float slideTimeMultiplier;

		private bool isFail;

		public bool IsOpen { get; private set; }

		public bool TutorialOpen { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void Open(global::ScheduleOne.NPCs.NPC _npc)
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		private void Update()
		{
		}

		private void StopArrow()
		{
		}

		public void SetSlotLocked(int index, bool locked)
		{
		}

		private global::ScheduleOne.UI.ItemSlotUI GetHoveredSlot()
		{
			return null;
		}

		private void Fail()
		{
		}

		public void Close()
		{
		}

		private void OpenTutorial()
		{
		}

		public void CloseTutorial()
		{
		}

		private float GetGreenAreaNormalizedPosition(int index)
		{
			return 0f;
		}

		private float GetGreenAreaNormalizedWidth(int index)
		{
			return 0f;
		}
	}
}
