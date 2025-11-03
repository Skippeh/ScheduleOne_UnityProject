namespace ScheduleOne.UI
{
	public class PauseMenu : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.PauseMenu>
	{
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::ScheduleOne.UI.MainMenu.MainMenuScreen Screen;

		public global::ScheduleOne.UI.FeedbackForm FeedbackForm;

		private bool noActiveUIElements;

		private bool justPaused;

		private bool justResumed;

		private bool couldLook;

		private bool lockedMouse;

		private bool crosshairVisible;

		private bool hudVisible;

		public global::System.Action onPause;

		public global::System.Action onResume;

		public bool IsPaused { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		public void StuckButtonClicked()
		{
		}
	}
}
