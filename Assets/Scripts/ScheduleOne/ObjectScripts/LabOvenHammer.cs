using ScheduleOne.PlayerTasks;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	public class LabOvenHammer : MonoBehaviour
	{
		public Draggable Draggable;

		public DraggableConstraint Constraint;

		public RotateRigidbodyToTarget Rotator;

		public Transform CoM;

		public Transform ImpactPoint;

		public SmoothedVelocityCalculator VelocityCalculator;

		[Header("Settings")]
		public float MinHeight;

		public float MaxHeight;

		public float MinAngle;

		public float MaxAngle;

		public UnityEvent<Collision> onCollision;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
