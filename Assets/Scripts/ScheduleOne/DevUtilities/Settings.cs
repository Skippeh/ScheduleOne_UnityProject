namespace ScheduleOne.DevUtilities
{
	public class Settings : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.DevUtilities.Settings>
	{
		public enum UnitType
		{
			Metric = 0,
			Imperial = 1
		}

		public const float MinYPos = -20f;

		public const string BETA_ARG = "-beta";

		public const string DISABLE_COUNTRY_CHECK_ARG = "-disablecountrycheck";

		public const bool COUNTRY_CHECK = false;

		public global::System.Collections.Generic.List<string> LaunchArgs;

		public global::ScheduleOne.DevUtilities.DisplaySettings DisplaySettings;

		public global::ScheduleOne.DevUtilities.DisplaySettings UnappliedDisplaySettings;

		public global::ScheduleOne.DevUtilities.GraphicsSettings GraphicsSettings;

		public global::ScheduleOne.DevUtilities.AudioSettings AudioSettings;

		public global::ScheduleOne.DevUtilities.InputSettings InputSettings;

		public global::UnityEngine.InputSystem.InputActionAsset InputActions;

		public global::ScheduleOne.GameInput GameInput;

		public global::UnityEngine.Rendering.Universal.ScriptableRendererFeature SSAO;

		public global::UnityEngine.Rendering.Universal.ScriptableRendererFeature GodRays;

		[global::UnityEngine.Header("Camera")]
		public float LookSensitivity;

		public bool InvertMouse;

		public float CameraFOV;

		public global::ScheduleOne.DevUtilities.InputSettings.EActionMode SprintMode;

		[global::UnityEngine.Range(0f, 1f)]
		public float CameraBobIntensity;

		private global::UnityEngine.InputSystem.InputActionMap playerControls;

		public global::System.Action onDisplayChanged;

		public global::System.Action onInputsApplied;

		public global::ScheduleOne.DevUtilities.Settings.UnitType unitType { get; protected set; }

		public bool PausingFreezesTime => false;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void CheckCountryCode()
		{
		}

		public void ApplyDisplaySettings(global::ScheduleOne.DevUtilities.DisplaySettings settings)
		{
		}

		private void MoveMainWindowTo(global::UnityEngine.DisplayInfo displayInfo)
		{
		}

		public void ReloadGraphicsSettings()
		{
		}

		public void ApplyGraphicsSettings(global::ScheduleOne.DevUtilities.GraphicsSettings settings)
		{
		}

		public void ReloadAudioSettings()
		{
		}

		public void ApplyAudioSettings(global::ScheduleOne.DevUtilities.AudioSettings settings)
		{
		}

		public void ReloadInputSettings()
		{
		}

		public void ApplyInputSettings(global::ScheduleOne.DevUtilities.InputSettings settings)
		{
		}

		public void WriteDisplaySettings(global::ScheduleOne.DevUtilities.DisplaySettings settings)
		{
		}

		public global::ScheduleOne.DevUtilities.DisplaySettings ReadDisplaySettings()
		{
			return default(global::ScheduleOne.DevUtilities.DisplaySettings);
		}

		public void WriteGraphicsSettings(global::ScheduleOne.DevUtilities.GraphicsSettings settings)
		{
		}

		public global::ScheduleOne.DevUtilities.GraphicsSettings ReadGraphicsSettings()
		{
			return null;
		}

		public void WriteAudioSettings(global::ScheduleOne.DevUtilities.AudioSettings settings)
		{
		}

		public global::ScheduleOne.DevUtilities.AudioSettings ReadAudioSettings()
		{
			return null;
		}

		public void WriteInputSettings(global::ScheduleOne.DevUtilities.InputSettings settings)
		{
		}

		public global::ScheduleOne.DevUtilities.InputSettings ReadInputSettings()
		{
			return null;
		}

		public string GetActionControlPath(string actionName)
		{
			return null;
		}
	}
}
