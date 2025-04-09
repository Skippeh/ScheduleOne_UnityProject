using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	public class LabOvenWireTray : MonoBehaviour
	{
		public const float HIT_OFFSET_MAX = 0.24f;

		public const float HIT_OFFSET_MIN = -0.25f;

		[Header("References")]
		public Transform Tray;

		public Transform PlaneNormal;

		public Transform ClosedPosition;

		public Transform OpenPosition;

		public LabOvenDoor OvenDoor;

		[Header("Settings")]
		public float MoveSpeed;

		public AnimationCurve DoorClampCurve;

		private Vector3 clickOffset;

		private bool isMoving;

		public bool Interactable { get; private set; }

		public float TargetPosition { get; private set; }

		public float ActualPosition { get; private set; }

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void Move()
		{
		}

		private void ClampAngle()
		{
		}

		public void SetInteractable(bool interactable)
		{
		}

		public void SetPosition(float position)
		{
		}

		public void ClickStart(RaycastHit hit)
		{
		}

		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}

		public void ClickEnd()
		{
		}
	}
}
