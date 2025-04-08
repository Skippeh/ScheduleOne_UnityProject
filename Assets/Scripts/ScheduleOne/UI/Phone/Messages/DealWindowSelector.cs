namespace ScheduleOne.UI.Phone.Messages
{
	public class DealWindowSelector : global::UnityEngine.MonoBehaviour
	{
		public const float TIME_ARM_ROTATION_0000 = 0f;

		public const float TIME_ARM_ROTATION_2400 = -360f;

		public const int WINDOW_CUTOFF_MINS = 120;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Economy.EDealWindow> OnSelected;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject Container;

		public global::ScheduleOne.UI.Phone.Messages.WindowSelectorButton MorningButton;

		public global::ScheduleOne.UI.Phone.Messages.WindowSelectorButton AfternoonButton;

		public global::ScheduleOne.UI.Phone.Messages.WindowSelectorButton NightButton;

		public global::ScheduleOne.UI.Phone.Messages.WindowSelectorButton LateNightButton;

		public global::UnityEngine.RectTransform CurrentTimeArm;

		public global::UnityEngine.UI.Text CurrentTimeLabel;

		private global::System.Action<global::ScheduleOne.Economy.EDealWindow> callback;

		private global::ScheduleOne.UI.Phone.Messages.WindowSelectorButton[] buttons;

		private bool hintShown;

		public bool IsOpen { get; private set; }

		private void Start()
		{
		}

		public void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void SetIsOpen(bool open)
		{
		}

		public void SetIsOpen(bool open, global::ScheduleOne.Messaging.MSGConversation conversation, global::System.Action<global::ScheduleOne.Economy.EDealWindow> callback = null)
		{
		}

		public void Update()
		{
		}

		private void UpdateTime()
		{
		}

		private void UpdateWindowValidity()
		{
		}

		private void Close()
		{
		}

		private void ButtonClicked(global::ScheduleOne.Economy.EDealWindow window)
		{
		}
	}
}
