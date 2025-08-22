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
			VehicleToggleLights = 15,
			VehicleHandbrake = 16,
			RotateLeft = 17,
			RotateRight = 18,
			ManagementMode = 19,
			OpenMap = 20,
			OpenJournal = 21,
			OpenTexts = 22,
			QuickMove = 23,
			ToggleFlashlight = 24,
			ViewAvatar = 25,
			Reload = 26,
			InventoryLeft = 27,
			InventoryRight = 28,
			Holster = 29,
			VehicleResetCamera = 30,
			SkateboardDismount = 31,
			SkateboardMount = 32
		}

		public enum InputDeviceType
		{
			KeyboardMouse = 0,
			Gamepad = 1
		}

		public class ExitListener
		{
			public global::ScheduleOne.GameInput.ExitDelegate listenerFunction;

			public int priority;
		}

		public delegate void ExitDelegate(global::ScheduleOne.DevUtilities.ExitAction exitAction);

		public static global::System.Action<global::ScheduleOne.GameInput.InputDeviceType> OnInputDeviceChanged;

		public static global::System.Collections.Generic.List<global::ScheduleOne.GameInput.ExitListener> exitListeners;

		public global::UnityEngine.InputSystem.PlayerInput PlayerInput;

		public static bool IsTyping;

		public static global::UnityEngine.Vector2 MotionAxis;

		public static global::UnityEngine.Vector2 CameraAxis;

		public static float MouseWheelAxis;

		public static bool ControllerComboActive;

		private global::System.Collections.Generic.List<global::ScheduleOne.GameInput.ButtonCode> buttonsDownThisFrame;

		private global::System.Collections.Generic.List<global::ScheduleOne.GameInput.ButtonCode> buttonsDown;

		private global::System.Collections.Generic.List<global::ScheduleOne.GameInput.ButtonCode> buttonsUpThisFrame;

		public static global::ScheduleOne.GameInput.InputDeviceType CurrentInputDevice { get; private set; }

		public static global::UnityEngine.Vector2 MouseDelta => default(global::UnityEngine.Vector2);

		public static global::UnityEngine.Vector3 MousePosition => default(global::UnityEngine.Vector3);

		public static float MouseScrollDelta => 0f;

		public static float VehicleDriveAxis { get; private set; }

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
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

		private void OnControlsChanged(global::UnityEngine.InputSystem.PlayerInput input)
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

		private void OnVehicleToggleLights()
		{
		}

		private void OnVehicleHandbrake()
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

		private void OnCamera(global::UnityEngine.InputSystem.InputValue value)
		{
		}

		private void OnScrollWheel(global::UnityEngine.InputSystem.InputValue value)
		{
		}

		private void OnInventoryLeft()
		{
		}

		private void OnInventoryRight()
		{
		}

		private void OnHolster()
		{
		}

		private void OnControllerCombo(global::UnityEngine.InputSystem.InputValue value)
		{
		}

		private void OnVehicleResetCamera()
		{
		}

		private void OnVehicleDrive(global::UnityEngine.InputSystem.InputValue value)
		{
		}

		private void OnSkateboardDismount()
		{
		}

		private void OnSkateboardMount()
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
