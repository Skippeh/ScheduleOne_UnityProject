namespace ScheduleOne.PlayerTasks
{
	public class Draggable : global::ScheduleOne.PlayerTasks.Clickable
	{
		public enum EDragProjectionMode
		{
			CameraForward = 0,
			FlatCameraForward = 1,
			CustomPlane = 2
		}

		public enum ERotationAxis
		{
			FlatCameraForward = 0,
			LocalX = 1,
			LocalY = 2,
			LocalZ = 3
		}

		[global::UnityEngine.Header("Drag Force")]
		public float DragForceMultiplier;

		public global::UnityEngine.Transform DragForceOrigin;

		[global::UnityEngine.Header("Rotation")]
		public bool RotationEnabled;

		public float TorqueMultiplier;

		public global::ScheduleOne.PlayerTasks.Draggable.ERotationAxis RotationAxis;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.PlayerTasks.Draggable.EDragProjectionMode DragProjectionMode;

		public global::UnityEngine.Transform CustomDragPlane;

		public bool DisableGravityWhenDragged;

		public float NormalRBDrag;

		public float HeldRBDrag;

		public bool CanBeMultiDragged;

		[global::UnityEngine.Header("Additional force")]
		public float idleUpForce;

		[global::UnityEngine.HideInInspector]
		public bool LocationRestrictionEnabled;

		[global::UnityEngine.HideInInspector]
		public global::UnityEngine.Vector3 Origin;

		[global::UnityEngine.HideInInspector]
		public float MaxDistanceFromOrigin;

		public global::UnityEngine.Events.UnityEvent<global::UnityEngine.Collider> onTriggerExit;

		protected global::ScheduleOne.PlayerTasks.DraggableConstraint constraint;

		public global::UnityEngine.Rigidbody Rb { get; protected set; }

		public override global::ScheduleOne.PlayerScripts.CursorManager.ECursorType HoveredCursor { get; protected set; }

		protected virtual void Awake()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void Update()
		{
		}

		public virtual void PostFixedUpdate()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void OnTriggerExit(global::UnityEngine.Collider other)
		{
		}

		public override void StartClick(global::UnityEngine.RaycastHit hit)
		{
		}

		public override void EndClick()
		{
		}
	}
}
