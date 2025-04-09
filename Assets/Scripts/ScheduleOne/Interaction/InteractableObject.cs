using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Interaction
{
	public class InteractableObject : MonoBehaviour
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

		[Header("Settings")]
		[SerializeField]
		protected string message;

		[SerializeField]
		protected EInteractionType interactionType;

		[SerializeField]
		protected EInteractableState interactionState;

		public float MaxInteractionRange;

		public bool RequiresUniqueClick;

		public int Priority;

		[SerializeField]
		protected Collider displayLocationCollider;

		public Transform displayLocationPoint;

		[Header("Angle Limits")]
		public bool LimitInteractionAngle;

		public float AngleLimit;

		[Header("Events")]
		public UnityEvent onHovered;

		public UnityEvent onInteractStart;

		public UnityEvent onInteractEnd;

		public EInteractionType _interactionType => default(EInteractionType);

		public EInteractableState _interactionState => default(EInteractableState);

		public void SetInteractionType(EInteractionType type)
		{
		}

		public void SetInteractableState(EInteractableState state)
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

		public bool CheckAngleLimit(Vector3 interactionSource)
		{
			return false;
		}
	}
}
