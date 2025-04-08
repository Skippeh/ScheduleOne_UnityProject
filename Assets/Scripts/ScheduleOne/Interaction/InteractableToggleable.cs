namespace ScheduleOne.Interaction
{
	public class InteractableToggleable : global::UnityEngine.MonoBehaviour
	{
		public string ActivateMessage;

		public string DeactivateMessage;

		public float CoolDown;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Events.UnityEvent onToggle;

		public global::UnityEngine.Events.UnityEvent onActivate;

		public global::UnityEngine.Events.UnityEvent onDeactivate;

		private float lastActivated;

		public bool IsActivated { get; private set; }

		public void Start()
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		public void Toggle()
		{
		}

		public void SetState(bool activated)
		{
		}

		public void PoliceDetected()
		{
		}
	}
}
