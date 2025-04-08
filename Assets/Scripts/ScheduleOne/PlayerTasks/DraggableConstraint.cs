namespace ScheduleOne.PlayerTasks
{
	public class DraggableConstraint : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Transform Container;

		public global::UnityEngine.Rigidbody Anchor;

		public bool ProportionalZClamp;

		public bool AlignUpToContainerPlane;

		[global::UnityEngine.Header("Up Direction Clamping")]
		public bool ClampUpDirection;

		public float UpDirectionMaxDifference;

		private global::UnityEngine.Vector3 startLocalPos;

		private global::ScheduleOne.PlayerTasks.Draggable draggable;

		private global::UnityEngine.ConfigurableJoint joint;

		private global::UnityEngine.Vector3 RelativePos => default(global::UnityEngine.Vector3);

		private void Start()
		{
		}

		public void SetContainer(global::UnityEngine.Transform container)
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
