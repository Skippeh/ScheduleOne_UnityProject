namespace ScheduleOne
{
	public class OnScreenMouse : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.OnScreenMouse>
	{
		private static readonly global::UnityEngine.Vector2 CURSOR_COORDINATE_REFERENCE;

		[global::UnityEngine.Tooltip("Unity new input system virtual mouse")]
		public global::UnityEngine.InputSystem.UI.VirtualMouseInput ptrComponent;

		private global::UnityEngine.InputSystem.Mouse systemMouse;

		private new void Awake()
		{
		}

		private void OnInputDeviceChanged(global::ScheduleOne.GameInput.InputDeviceType type)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void SetTexture(global::UnityEngine.Texture tex, global::UnityEngine.Vector2 hotSpot)
		{
		}

		private void SetVirtualMouseEnabled(bool isOn)
		{
		}

		private void UpdateSystemMouseValues()
		{
		}
	}
}
