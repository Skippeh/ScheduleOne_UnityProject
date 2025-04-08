namespace ScheduleOne.UI
{
	public class GameplayMenu : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.GameplayMenu>
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

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Camera OverlayCamera;

		public global::UnityEngine.Light OverlayLight;

		[global::UnityEngine.Header("Settings")]
		public float ContainerOffset_PhoneScreen;

		private global::UnityEngine.Coroutine openCloseRoutine;

		private global::UnityEngine.Coroutine screenChangeRoutine;

		public bool IsOpen { get; protected set; }

		public bool CharacterScreenEnabled => false;

		public global::ScheduleOne.UI.GameplayMenu.EGameplayScreen CurrentScreen { get; protected set; }

		protected override void Start()
		{
		}

		public void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		protected virtual void Update()
		{
		}

		public void SetScreen(global::ScheduleOne.UI.GameplayMenu.EGameplayScreen screen)
		{
		}

		public void SetIsOpen(bool open)
		{
		}
	}
}
