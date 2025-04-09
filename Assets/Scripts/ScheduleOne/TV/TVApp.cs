using ScheduleOne.DevUtilities;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.TV
{
	public class TVApp : MonoBehaviour
	{
		public const float SCALE_MIN = 0.67f;

		public const float SCALE_MAX = 1.5f;

		public const float LERP_TIME = 0.12f;

		[Header("Settings")]
		public bool CanClose;

		public string AppName;

		public Sprite Icon;

		public bool Pauseable;

		[Header("References")]
		public Canvas Canvas;

		[HideInInspector]
		public TVApp PreviousScreen;

		public CanvasGroup CanvasGroup;

		public TVPauseScreen PauseScreen;

		private Coroutine lerpCoroutine;

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

		private void Exit(ExitAction action)
		{
		}

		protected virtual void TryPause()
		{
		}
	}
}
