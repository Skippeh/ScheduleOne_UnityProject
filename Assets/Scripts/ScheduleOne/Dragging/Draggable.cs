namespace ScheduleOne.Dragging
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Interaction.InteractableObject))]
	public class Draggable : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable
	{
		public enum EInitialReplicationMode
		{
			Off = 0,
			OnlyIfMoved = 1,
			Full = 2
		}

		public const float INITIAL_REPLICATION_DISTANCE = 1f;

		public const float MAX_DRAG_START_RANGE = 2.5f;

		public const float MAX_TARGET_OFFSET = 1.5f;

		private bool isBeingDragged;

		private global::ScheduleOne.PlayerScripts.Player currentDragger;

		[global::UnityEngine.SerializeField]
		protected string BakedGUID;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Rigidbody Rigidbody;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform DragOrigin;

		[global::UnityEngine.Header("Settings")]
		public bool CreateCoM;

		[global::UnityEngine.Range(0.5f, 2f)]
		public float HoldDistanceMultiplier;

		[global::UnityEngine.Range(0f, 5f)]
		public float DragForceMultiplier;

		public global::ScheduleOne.Dragging.Draggable.EInitialReplicationMode InitialReplicationMode;

		private float timeSinceLastDrag;

		public global::UnityEngine.Events.UnityEvent onDragStart;

		public global::UnityEngine.Events.UnityEvent onDragEnd;

		public global::UnityEngine.Events.UnityEvent onHovered;

		public global::UnityEngine.Events.UnityEvent onInteracted;

		public bool IsBeingDragged => false;

		public global::ScheduleOne.PlayerScripts.Player CurrentDragger
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public global::System.Guid GUID { get; protected set; }

		public global::UnityEngine.Vector3 initialPosition { get; private set; }

		[global::EasyButtons.Button]
		public void RegenerateGUID()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		protected void OnValidate()
		{
		}

		protected void OnDestroy()
		{
		}

		public void UpdateDraggable(float fixedDeltaTime)
		{
		}

		public void ApplyDragForces(global::UnityEngine.Vector3 targetPosition)
		{
		}

		protected virtual void Hovered()
		{
		}

		protected virtual void Interacted()
		{
		}

		private bool CanInteract()
		{
			return false;
		}

		public void StartDragging(global::ScheduleOne.PlayerScripts.Player dragger)
		{
		}

		public void StopDragging()
		{
		}
	}
}
