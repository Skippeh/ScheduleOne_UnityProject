namespace ScheduleOne
{
	public class GameInput : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.GameInput>
	{
		public enum ButtonCode
		{
			PrimaryClick = 0,
			SecondaryClick = 1,
			TertiaryClick = 2,
			Forward = 3,
			Backward = 4,
			Left = 5,
			Right = 6,
			Jump = 7,
			Crouch = 8,
			Sprint = 9,
			Escape = 10,
			Back = 11,
			Interact = 12,
			Submit = 13,
			TogglePhone = 14,
			ToggleLights = 15,
			Handbrake = 16,
			RotateLeft = 17,
			RotateRight = 18,
			ManagementMode = 19,
			OpenMap = 20,
			OpenJournal = 21,
			OpenTexts = 22,
			QuickMove = 23,
			ToggleFlashlight = 24,
			ViewAvatar = 25,
			Reload = 26
		}

		public class ExitListener
		{
			public global::ScheduleOne.GameInput.ExitDelegate listenerFunction;

			public int priority;
		}

		public delegate void ExitDelegate(global::ScheduleOne.DevUtilities.ExitAction exitAction);

		public static global::System.Collections.Generic.List<global::ScheduleOne.GameInput.ExitListener> exitListeners;

		public global::UnityEngine.InputSystem.PlayerInput PlayerInput;

		public static bool IsTyping;

		public static global::UnityEngine.Vector2 MotionAxis;

		private global::System.Collections.Generic.List<global::ScheduleOne.GameInput.ButtonCode> buttonsDownThisFrame;

		private global::System.Collections.Generic.List<global::ScheduleOne.GameInput.ButtonCode> buttonsDown;

		private global::System.Collections.Generic.List<global::ScheduleOne.GameInput.ButtonCode> buttonsUpThisFrame;

		public static global::UnityEngine.Vector2 MouseDelta => default(global::UnityEngine.Vector2);

		public static global::UnityEngine.Vector3 MousePosition => default(global::UnityEngine.Vector3);

		public static float MouseScrollDelta => 0f;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void OnApplicationFocus(bool focus)
		{
		}

		public static bool GetButton(global::ScheduleOne.GameInput.ButtonCode buttonCode)
		{
			return false;
		}

		public static bool GetButtonDown(global::ScheduleOne.GameInput.ButtonCode buttonCode)
		{
			return false;
		}

		public static bool GetButtonUp(global::ScheduleOne.GameInput.ButtonCode buttonCode)
		{
			return false;
		}

		protected virtual void Update()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitType type)
		{
		}

		private void LateUpdate()
		{
		}

		public void ExitAll()
		{
		}

		private void OnMotion(global::UnityEngine.InputSystem.InputValue value)
		{
		}

		private void OnPrimaryClick()
		{
		}

		private void OnSecondaryClick()
		{
		}

		private void OnTertiaryClick()
		{
		}

		private void OnJump()
		{
		}

		private void OnCrouch()
		{
		}

		private void OnSprint()
		{
		}

		private void OnEscape()
		{
		}

		private void OnBack()
		{
		}

		private void OnInteract()
		{
		}

		private void OnSubmit()
		{
		}

		private void OnTogglePhone()
		{
		}

		private void OnToggleLights()
		{
		}

		private void OnHandbrake()
		{
		}

		private void OnRotateLeft()
		{
		}

		private void OnRotateRight()
		{
		}

		private void OnManagementMode()
		{
		}

		private void OnOpenMap()
		{
		}

		private void OnOpenJournal()
		{
		}

		private void OnOpenTexts()
		{
		}

		private void OnQuickMove()
		{
		}

		private void OnToggleFlashlight()
		{
		}

		private void OnViewAvatar()
		{
		}

		private void OnReload()
		{
		}

		public static void RegisterExitListener(global::ScheduleOne.GameInput.ExitDelegate listener, int priority = 0)
		{
		}

		public static void DeregisterExitListener(global::ScheduleOne.GameInput.ExitDelegate listener)
		{
		}

		public global::UnityEngine.InputSystem.InputAction GetAction(global::ScheduleOne.GameInput.ButtonCode code)
		{
			return null;
		}
	}
}
