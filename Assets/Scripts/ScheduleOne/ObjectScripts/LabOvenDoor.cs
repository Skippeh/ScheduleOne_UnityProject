namespace ScheduleOne.ObjectScripts
{
	public class LabOvenDoor : global::UnityEngine.MonoBehaviour
	{
		public const float HIT_OFFSET_MAX = 0.24f;

		public const float HIT_OFFSET_MIN = -0.25f;

		public const float DOOR_ANGLE_CLOSED = 90f;

		public const float DOOR_ANGLE_OPEN = 10f;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.PlayerTasks.Clickable HandleClickable;

		public global::UnityEngine.Transform Door;

		public global::UnityEngine.Transform PlaneNormal;

		public global::UnityEngine.AnimationCurve HitMapCurve;

		[global::UnityEngine.Header("Sounds")]
		public global::ScheduleOne.Audio.AudioSourceController OpenSound;

		public global::ScheduleOne.Audio.AudioSourceController CloseSound;

		public global::ScheduleOne.Audio.AudioSourceController ShutSound;

		[global::UnityEngine.Header("Settings")]
		public float DoorMoveSpeed;

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

		public void SetInteractable(bool interactable)
		{
		}

		public void SetPosition(float newPosition)
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
