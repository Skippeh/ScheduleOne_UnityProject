using ScheduleOne.Materials;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	public class LocalPlayerFootstepGenerator : MonoBehaviour
	{
		public float DistancePerStep;

		public Transform ReferencePoint;

		public LayerMask GroundDetectionMask;

		public UnityEvent<EMaterialType, float> onStep;

		private float currentDistance;

		private Vector3 lastFramePosition;

		private void LateUpdate()
		{
		}

		public void TriggerStep()
		{
		}

		public bool IsGrounded(out EMaterialType surfaceType)
		{
			surfaceType = default(EMaterialType);
			return false;
		}
	}
}
