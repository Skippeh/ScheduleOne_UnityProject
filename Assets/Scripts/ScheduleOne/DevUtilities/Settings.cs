using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.DevUtilities
{
	public class Settings : PersistentSingleton<Settings>
	{
		public enum UnitType
		{
			Metric = 0,
			Imperial = 1
		}

		public const float MinYPos = -20f;

		public DisplaySettings DisplaySettings;

		public DisplaySettings UnappliedDisplaySettings;

		public GraphicsSettings GraphicsSettings;

		public AudioSettings AudioSettings;

		public InputSettings InputSettings;

		public InputActionAsset InputActions;

		public GameInput GameInput;

		public ScriptableRendererFeature SSAO;

		public ScriptableRendererFeature GodRays;

		[Header("Camera")]
		public float LookSensitivity;

		public bool InvertMouse;

		public float CameraFOV;

		public InputSettings.EActionMode SprintMode;

		[Range(0f, 1f)]
		public float CameraBobIntensity;

		private InputActionMap playerControls;

		public Action onDisplayChanged;

		public Action onInputsApplied;

		public UnitType unitType { get; protected set; }

		public bool PausingFreezesTime => false;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void ApplyDisplaySettings(DisplaySettings settings)
		{
		}

		private void MoveMainWindowTo(DisplayInfo displayInfo)
		{
		}

		public void ReloadGraphicsSettings()
		{
		}

		public void ApplyGraphicsSettings(GraphicsSettings settings)
		{
		}

		public void ReloadAudioSettings()
		{
		}

		public void ApplyAudioSettings(AudioSettings settings)
		{
		}

		public void ReloadInputSettings()
		{
		}

		public void ApplyInputSettings(InputSettings settings)
		{
		}

		public void WriteDisplaySettings(DisplaySettings settings)
		{
		}

		public DisplaySettings ReadDisplaySettings()
		{
			return default(DisplaySettings);
		}

		public void WriteGraphicsSettings(GraphicsSettings settings)
		{
		}

		public GraphicsSettings ReadGraphicsSettings()
		{
			return null;
		}

		public void WriteAudioSettings(AudioSettings settings)
		{
		}

		public AudioSettings ReadAudioSettings()
		{
			return null;
		}

		public void WriteInputSettings(InputSettings settings)
		{
		}

		public InputSettings ReadInputSettings()
		{
			return null;
		}

		public string GetActionControlPath(string actionName)
		{
			return null;
		}
	}
}
