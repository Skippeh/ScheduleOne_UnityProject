namespace ScheduleOne.UI
{
	public abstract class App<T> : global::ScheduleOne.DevUtilities.PlayerSingleton<T> where T : global::ScheduleOne.DevUtilities.PlayerSingleton<T>
	{
		public enum EOrientation
		{
			Horizontal = 0,
			Vertical = 1
		}

		public static global::System.Collections.Generic.List<global::ScheduleOne.UI.App<T>> Apps;

		[global::UnityEngine.Header("Settings")]
		public string AppName;

		public string IconLabel;

		public global::UnityEngine.Sprite AppIcon;

		public global::ScheduleOne.UI.App<T>.EOrientation Orientation;

		public bool AvailableInTutorial;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform appContainer;

		protected global::UnityEngine.RectTransform notificationContainer;

		protected global::UnityEngine.UI.Text notificationText;

		protected global::UnityEngine.UI.Button appIconButton;

		public bool isOpen { get; protected set; }

		public static global::ScheduleOne.UI.App<T> GetApp(int index)
		{
			return null;
		}

		public override void OnStartClient(bool IsOwner)
		{
		}

		protected override void Start()
		{
		}

		private void Close()
		{
		}

		protected virtual void Update()
		{
		}

		private bool IsHoveringButton()
		{
			return false;
		}

		private void GenerateHomeScreenIcon()
		{
		}

		public void SetNotificationCount(int amount)
		{
		}

		protected virtual void OnPhoneOpened()
		{
		}

		private void ShortcutClicked()
		{
		}

		public virtual void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		public virtual void SetOpen(bool open)
		{
		}
	}
}
