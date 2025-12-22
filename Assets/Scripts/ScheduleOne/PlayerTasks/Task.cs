namespace ScheduleOne.PlayerTasks
{
	public class Task
	{
		public enum EOutcome
		{
			Cancelled = 0,
			Success = 1,
			Fail = 2
		}

		public const float ClickDetectionRange = 3f;

		public float ClickDetectionRadius;

		protected float MultiGrabRadius;

		public const float MultiGrabForceMultiplier = 1.25f;

		public bool ClickDetectionEnabled;

		public global::ScheduleOne.PlayerTasks.Task.EOutcome Outcome;

		public global::System.Action onTaskSuccess;

		public global::System.Action onTaskFail;

		public global::System.Action onTaskStop;

		protected global::ScheduleOne.PlayerTasks.Clickable clickable;

		protected global::ScheduleOne.PlayerTasks.Draggable draggable;

		protected global::ScheduleOne.PlayerTasks.DraggableConstraint constraint;

		protected float hitDistance;

		protected global::UnityEngine.Vector3 relativeHitOffset;

		private bool multiDraggingEnabled;

		private global::UnityEngine.Transform multiGrabProjectionPlane;

		private global::System.Collections.Generic.List<global::ScheduleOne.PlayerTasks.Draggable> multiDragTargets;

		private bool isMultiDragging;

		private global::System.Collections.Generic.List<global::ScheduleOne.PlayerTasks.Clickable> forcedClickables;

		protected global::UnityEngine.LayerMask clickablesLayerMask;

		public virtual string TaskName { get; protected set; }

		public string CurrentInstruction { get; protected set; }

		public bool TaskActive { get; private set; }

		public virtual void StopTask()
		{
		}

		public virtual void Success()
		{
		}

		public virtual void Fail()
		{
		}

		public virtual void Update()
		{
		}

		protected virtual void UpdateCursor()
		{
		}

		public virtual void LateUpdate()
		{
		}

		private global::UnityEngine.Vector3 GetMultiDragOrigin()
		{
			return default(global::UnityEngine.Vector3);
		}

		public virtual void FixedUpdate()
		{
		}

		public void ForceStartClick(global::ScheduleOne.PlayerTasks.Clickable _clickable)
		{
		}

		public void ForceEndClick(global::ScheduleOne.PlayerTasks.Clickable _clickable)
		{
		}

		private void UpdateDraggablePhysics()
		{
		}

		protected virtual global::ScheduleOne.PlayerTasks.Clickable GetClickable(out global::UnityEngine.RaycastHit hit)
		{
			hit = default(global::UnityEngine.RaycastHit);
			return null;
		}

		protected void EnableMultiDragging(global::UnityEngine.Transform projectionPlane, float radius = 0.08f)
		{
		}
	}
}
