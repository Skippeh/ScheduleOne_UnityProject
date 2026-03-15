namespace ScheduleOne
{
	public class UIScreenManager : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.UIScreenManager>
	{
		public struct UIScreenInfo
		{
			public global::ScheduleOne.UIScreen screen;

			public global::System.Action onCloseCallback;
		}

		public const float NavigationRepeatDelay = 0.5f;

		public const float NavigationRepeatRate = 0.125f;

		public const float DefaultScrollSpeed = 0.15f;

		public const float ScrollbarScrollSpeed = 25f;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UIPopupScreen[] popupScreenPrefabs;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Default 'A' button on controller for basic selectable interaction. Used in UITrigger")]
		private global::UnityEngine.InputSystem.InputActionReference submitInputAction;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Default 'B' button on controller, RightMouseButton for back interaction. Used in UIScreenManager")]
		private global::UnityEngine.InputSystem.InputActionReference backInputAction;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Default 'Start' button on controller, Escape key for back interaction. Used in UIScreenManager")]
		private global::UnityEngine.InputSystem.InputActionReference escapeInputAction;

		private global::System.Collections.Generic.List<global::ScheduleOne.UIPopupScreen> popupScreenInstances;

		private global::System.Collections.Generic.Stack<global::ScheduleOne.UIScreenManager.UIScreenInfo> screenStack;

		private static global::UnityEngine.GameObject lastSelectedObject;

		private static bool isBackTriggeredThisFrame;

		public global::UnityEngine.InputSystem.InputActionReference SubmitInputAction => null;

		public static global::UnityEngine.GameObject LastSelectedObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool IsBackTriggeredThisFrame => false;

		public global::ScheduleOne.UIScreen TopScreen => null;

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void BackToCloseCurrentScreen()
		{
		}

		public bool IsActiveScreenRegisteredForBack()
		{
			return false;
		}

		private void HandleInputDeviceChanged(global::ScheduleOne.GameInput.InputDeviceType type)
		{
		}

		private void CheckInputDeviceMode()
		{
		}

		private void OnSceneLoaded(global::UnityEngine.SceneManagement.Scene scene, global::UnityEngine.SceneManagement.LoadSceneMode mode)
		{
		}

		public void AddScreen(global::ScheduleOne.UIScreen screen, global::System.Action onCloseCallback = null)
		{
		}

		public void RemoveScreen(global::ScheduleOne.UIScreen screen)
		{
		}

		private bool IsScreenInStack(global::ScheduleOne.UIScreen screen)
		{
			return false;
		}

		public bool IsAnyScreenActive()
		{
			return false;
		}

		public bool IsAnyPopupScreenActive()
		{
			return false;
		}

		public void OpenPopupScreen(string popupID)
		{
		}

		public void OpenPopupScreen(string popupID, params object[] args)
		{
		}

		public void ClosePopupScreen(string popupID)
		{
		}

		private global::ScheduleOne.UIPopupScreen FindPopupScreen(string popupID)
		{
			return null;
		}
	}
}
