namespace ScheduleOne.UI
{
	public class SleepCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.SleepCanvas>
	{
		public const int MaxSleepTime = 12;

		public const int MinSleepTime = 4;

		private float QueuedMessageDisplayTime;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.RectTransform MenuContainer;

		public global::TMPro.TextMeshProUGUI CurrentTimeLabel;

		public global::UnityEngine.UI.Button IncreaseButton;

		public global::UnityEngine.UI.Button DecreaseButton;

		public global::TMPro.TextMeshProUGUI EndTimeLabel;

		public global::UnityEngine.UI.Button SleepButton;

		public global::TMPro.TextMeshProUGUI SleepButtonLabel;

		public global::UnityEngine.UI.Image BlackOverlay;

		public global::TMPro.TextMeshProUGUI SleepMessageLabel;

		public global::UnityEngine.CanvasGroup SleepMessageGroup;

		public global::TMPro.TextMeshProUGUI TimeLabel;

		public global::TMPro.TextMeshProUGUI WakeLabel;

		public global::TMPro.TextMeshProUGUI WaitingForHostLabel;

		public global::UnityEngine.Events.UnityEvent onSleepFullyFaded;

		public global::UnityEngine.Events.UnityEvent onSleepEndFade;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.IPostSleepEvent> queuedPostSleepEvents;

		public bool IsMenuOpen { get; protected set; }

		public string QueuedSleepMessage { get; protected set; }

		protected override void Awake()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void SetIsOpen(bool open)
		{
		}

		public void Update()
		{
		}

		public void AddPostSleepEvent(global::ScheduleOne.UI.IPostSleepEvent postSleepEvent)
		{
		}

		private void UpdateHourSetting()
		{
		}

		private void UpdateTimeLabels()
		{
		}

		private void UpdateSleepButton()
		{
		}

		private void ChangeSleepAmount(int change)
		{
		}

		private int ClampWakeTime(int time)
		{
			return 0;
		}

		private int ClampTime(int time, int startTime, int endTime)
		{
			return 0;
		}

		private void SleepButtonPressed()
		{
		}

		private void SleepStart()
		{
		}

		private void LerpBlackOverlay(float transparency, float lerpTime)
		{
		}

		public void QueueSleepMessage(string message, float displayTime = 3f)
		{
		}
	}
}
