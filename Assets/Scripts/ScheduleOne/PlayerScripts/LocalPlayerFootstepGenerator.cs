namespace ScheduleOne.PlayerScripts
{
	public class LocalPlayerFootstepGenerator : global::UnityEngine.MonoBehaviour
	{
		public float DistancePerStep;

		public global::UnityEngine.Transform ReferencePoint;

		public global::UnityEngine.LayerMask GroundDetectionMask;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Materials.EMaterialType, float> onStep;

		private float currentDistance;

		private global::UnityEngine.Vector3 lastFramePosition;

		private void LateUpdate()
		{
		}

		public void TriggerStep()
		{
		}

		public bool IsGrounded(out global::ScheduleOne.Materials.EMaterialType surfaceType)
		{
			surfaceType = default(global::ScheduleOne.Materials.EMaterialType);
			return false;
		}
	}
}
