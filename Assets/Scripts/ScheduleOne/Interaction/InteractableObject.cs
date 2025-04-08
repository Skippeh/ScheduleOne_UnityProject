namespace ScheduleOne.Interaction
{
	public class InteractableObject : global::UnityEngine.MonoBehaviour
	{
		public enum EInteractionType
		{
			Key_Press = 0,
			LeftMouse_Click = 1
		}

		public enum EInteractableState
		{
			Default = 0,
			Invalid = 1,
			Disabled = 2,
			Label = 3
		}

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected string message;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject.EInteractionType interactionType;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject.EInteractableState interactionState;

		public float MaxInteractionRange;

		public bool RequiresUniqueClick;

		public int Priority;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Collider displayLocationCollider;

		public global::UnityEngine.Transform displayLocationPoint;

		[global::UnityEngine.Header("Angle Limits")]
		public bool LimitInteractionAngle;

		public float AngleLimit;

		[global::UnityEngine.Header("Events")]
		public global::UnityEngine.Events.UnityEvent onHovered;

		public global::UnityEngine.Events.UnityEvent onInteractStart;

		public global::UnityEngine.Events.UnityEvent onInteractEnd;

		public global::ScheduleOne.Interaction.InteractableObject.EInteractionType _interactionType => default(global::ScheduleOne.Interaction.InteractableObject.EInteractionType);

		public global::ScheduleOne.Interaction.InteractableObject.EInteractableState _interactionState => default(global::ScheduleOne.Interaction.InteractableObject.EInteractableState);

		public void SetInteractionType(global::ScheduleOne.Interaction.InteractableObject.EInteractionType type)
		{
		}

		public void SetInteractableState(global::ScheduleOne.Interaction.InteractableObject.EInteractableState state)
		{
		}

		public void SetMessage(string _message)
		{
		}

		public virtual void Hovered()
		{
		}

		public virtual void StartInteract()
		{
		}

		public virtual void EndInteract()
		{
		}

		protected virtual void ShowMessage()
		{
		}

		public bool CheckAngleLimit(global::UnityEngine.Vector3 interactionSource)
		{
			return false;
		}
	}
}
