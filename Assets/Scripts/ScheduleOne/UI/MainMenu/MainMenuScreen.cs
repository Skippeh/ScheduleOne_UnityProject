namespace ScheduleOne.UI.MainMenu
{
	public class MainMenuScreen : global::UnityEngine.MonoBehaviour
	{
		public const float LERP_TIME = 0.075f;

		public const float LERP_SCALE = 1.25f;

		[global::UnityEngine.Header("Settings")]
		public int ExitInputPriority;

		public bool OpenOnStart;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.UI.MainMenu.MainMenuScreen PreviousScreen;

		public global::UnityEngine.CanvasGroup Group;

		private global::UnityEngine.RectTransform Rect;

		private global::UnityEngine.Coroutine lerpRoutine;

		public bool IsOpen { get; protected set; }

		protected virtual void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public virtual void Open(bool closePrevious)
		{
		}

		public virtual void Close(bool openPrevious)
		{
		}

		private void Lerp(bool open)
		{
		}
	}
}
