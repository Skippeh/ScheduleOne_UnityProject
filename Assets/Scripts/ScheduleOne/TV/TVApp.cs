namespace ScheduleOne.TV
{
	public class TVApp : global::UnityEngine.MonoBehaviour
	{
		public const float SCALE_MIN = 0.67f;

		public const float SCALE_MAX = 1.5f;

		public const float LERP_TIME = 0.12f;

		[global::UnityEngine.Header("Settings")]
		public bool CanClose;

		public string AppName;

		public global::UnityEngine.Sprite Icon;

		public bool Pauseable;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		[global::UnityEngine.HideInInspector]
		public global::ScheduleOne.TV.TVApp PreviousScreen;

		public global::UnityEngine.CanvasGroup CanvasGroup;

		public global::ScheduleOne.UI.TVPauseScreen PauseScreen;

		private global::UnityEngine.Coroutine lerpCoroutine;

		public bool IsOpen { get; private set; }

		public bool IsPaused => false;

		protected virtual void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public virtual void Open()
		{
		}

		public virtual void Close()
		{
		}

		public virtual void Resume()
		{
		}

		private void Lerp(float endScale, float endAlpha)
		{
		}

		protected virtual void ActiveMinPass()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		protected virtual void TryPause()
		{
		}
	}
}
