using System;
using System.Collections.Generic;
using UnityEngine;

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

		public EOutcome Outcome;

		public Action onTaskSuccess;

		public Action onTaskFail;

		public Action onTaskStop;

		protected Clickable clickable;

		protected Draggable draggable;

		protected DraggableConstraint constraint;

		protected float hitDistance;

		protected Vector3 relativeHitOffset;

		private bool multiDraggingEnabled;

		private Transform multiGrabProjectionPlane;

		private List<Draggable> multiDragTargets;

		private bool isMultiDragging;

		private List<Clickable> forcedClickables;

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

		private Vector3 GetMultiDragOrigin()
		{
			return default(Vector3);
		}

		public virtual void FixedUpdate()
		{
		}

		public void ForceStartClick(Clickable _clickable)
		{
		}

		public void ForceEndClick(Clickable _clickable)
		{
		}

		private void UpdateDraggablePhysics()
		{
		}

		protected virtual Clickable GetClickable(out RaycastHit hit)
		{
			hit = default(RaycastHit);
			return null;
		}

		protected void EnableMultiDragging(Transform projectionPlane, float radius = 0.08f)
		{
		}
	}
}
