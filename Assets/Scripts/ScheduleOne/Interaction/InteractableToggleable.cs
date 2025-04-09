using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Interaction
{
	public class InteractableToggleable : MonoBehaviour
	{
		public string ActivateMessage;

		public string DeactivateMessage;

		public float CoolDown;

		[Header("References")]
		public InteractableObject IntObj;

		public UnityEvent onToggle;

		public UnityEvent onActivate;

		public UnityEvent onDeactivate;

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
