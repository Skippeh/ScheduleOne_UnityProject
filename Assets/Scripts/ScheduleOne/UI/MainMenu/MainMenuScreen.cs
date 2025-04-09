using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI.MainMenu
{
	public class MainMenuScreen : MonoBehaviour
	{
		public const float LERP_TIME = 0.075f;

		public const float LERP_SCALE = 1.25f;

		[Header("Settings")]
		public int ExitInputPriority;

		public bool OpenOnStart;

		[Header("References")]
		public MainMenuScreen PreviousScreen;

		public CanvasGroup Group;

		private RectTransform Rect;

		private Coroutine lerpRoutine;

		public bool IsOpen { get; protected set; }

		protected virtual void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void Exit(ExitAction action)
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
