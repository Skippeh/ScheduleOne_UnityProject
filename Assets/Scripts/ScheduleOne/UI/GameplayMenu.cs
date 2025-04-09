using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class GameplayMenu : Singleton<GameplayMenu>
	{
		public enum EGameplayScreen
		{
			Phone = 0,
			Character = 1
		}

		public const float OpenVerticalOffset = 0.02f;

		public const float ClosedVerticalOffset = -2f;

		public const float OpenTime = 0.06f;

		public const float SlideTime = 0.12f;

		[Header("References")]
		public Camera OverlayCamera;

		public Light OverlayLight;

		[Header("Settings")]
		public float ContainerOffset_PhoneScreen;

		private Coroutine openCloseRoutine;

		private Coroutine screenChangeRoutine;

		public bool IsOpen { get; protected set; }

		public bool CharacterScreenEnabled => false;

		public EGameplayScreen CurrentScreen { get; protected set; }

		protected override void Start()
		{
		}

		public void Exit(ExitAction exit)
		{
		}

		protected virtual void Update()
		{
		}

		public void SetScreen(EGameplayScreen screen)
		{
		}

		public void SetIsOpen(bool open)
		{
		}
	}
}
