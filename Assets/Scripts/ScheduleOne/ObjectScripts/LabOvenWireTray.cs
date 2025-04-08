namespace ScheduleOne.ObjectScripts
{
	public class LabOvenWireTray : global::UnityEngine.MonoBehaviour
	{
		public const float HIT_OFFSET_MAX = 0.24f;

		public const float HIT_OFFSET_MIN = -0.25f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform Tray;

		public global::UnityEngine.Transform PlaneNormal;

		public global::UnityEngine.Transform ClosedPosition;

		public global::UnityEngine.Transform OpenPosition;

		public global::ScheduleOne.ObjectScripts.LabOvenDoor OvenDoor;

		[global::UnityEngine.Header("Settings")]
		public float MoveSpeed;

		public global::UnityEngine.AnimationCurve DoorClampCurve;

		private global::UnityEngine.Vector3 clickOffset;

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

		public void ClickStart(global::UnityEngine.RaycastHit hit)
		{
		}

		private global::UnityEngine.Vector3 GetPlaneHit()
		{
			return default(global::UnityEngine.Vector3);
		}

		public void ClickEnd()
		{
		}
	}
}
