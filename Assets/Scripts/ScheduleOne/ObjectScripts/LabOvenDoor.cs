using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	public class LabOvenDoor : MonoBehaviour
	{
		public const float HIT_OFFSET_MAX = 0.24f;

		public const float HIT_OFFSET_MIN = -0.25f;

		public const float DOOR_ANGLE_CLOSED = 90f;

		public const float DOOR_ANGLE_OPEN = 10f;

		[Header("References")]
		public Clickable HandleClickable;

		public Transform Door;

		public Transform PlaneNormal;

		public AnimationCurve HitMapCurve;

		[Header("Sounds")]
		public AudioSourceController OpenSound;

		public AudioSourceController CloseSound;

		public AudioSourceController ShutSound;

		[Header("Settings")]
		public float DoorMoveSpeed;

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

		public void SetInteractable(bool interactable)
		{
		}

		public void SetPosition(float newPosition)
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
