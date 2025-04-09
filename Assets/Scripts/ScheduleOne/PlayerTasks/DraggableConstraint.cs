using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	public class DraggableConstraint : MonoBehaviour
	{
		public Transform Container;

		public Rigidbody Anchor;

		public bool ProportionalZClamp;

		public bool AlignUpToContainerPlane;

		[Header("Up Direction Clamping")]
		public bool ClampUpDirection;

		public float UpDirectionMaxDifference;

		private Vector3 startLocalPos;

		private Draggable draggable;

		private ConfigurableJoint joint;

		private Vector3 RelativePos => default(Vector3);

		private void Start()
		{
		}

		public void SetContainer(Transform container)
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void ProportionalClamp()
		{
		}

		private void LockRotationX()
		{
		}

		private void LockRotationY()
		{
		}

		private void AlignToContainerPlane()
		{
		}

		private void ClampUpRot()
		{
		}
	}
}
