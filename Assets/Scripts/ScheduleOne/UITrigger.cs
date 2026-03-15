namespace ScheduleOne
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.UI.Selectable))]
	public class UITrigger : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerUpHandler, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IPointerExitHandler
	{
		public enum TriggerType
		{
			Press = 0,
			Hold = 1
		}

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UITrigger.TriggerType triggerType;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Set to true if you want Mouse to be always Press")]
		private bool mouseAlwaysPress;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Duration in seconds to hold for Hold trigger")]
		private float holdDuration;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Optional UI image to show hold progress (should be Image Type: Filled)")]
		private global::UnityEngine.UI.Image holdImage;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Optional UGUI Selectable. If assigned, the uiTrigger interactable will also check for the UGUI Selectable interactable property.")]
		private global::UnityEngine.UI.Selectable uGUISelectable;

		[global::UnityEngine.Tooltip("Event triggered when the action is performed")]
		public global::UnityEngine.Events.UnityEvent OnTrigger;

		private bool isHolding;

		private float holdTime;

		private bool isHoldStarted;

		private bool interactable;

		public bool Interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::UnityEngine.UI.Image HoldImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal global::ScheduleOne.UITrigger.TriggerType GetTriggerType()
		{
			return default(global::ScheduleOne.UITrigger.TriggerType);
		}

		protected virtual void Awake()
		{
		}

		private bool IsInteractable()
		{
			return false;
		}

		private void Update()
		{
		}

		internal virtual void OnReset()
		{
		}

		internal virtual void DetectTriggerInput(global::UnityEngine.InputSystem.InputActionReference inputAction)
		{
		}

		internal void OnInputDown()
		{
		}

		internal void OnInputUp()
		{
		}

		public virtual void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
		{
		}

		public virtual void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
		{
		}

		public virtual void OnPointerExit(global::UnityEngine.EventSystems.PointerEventData eventData)
		{
		}

		public virtual void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
		{
		}

		private void HandleHoldStart()
		{
		}

		private void HandleHoldEnd()
		{
		}

		private void UpdateHoldImage(float amount)
		{
		}
	}
}
