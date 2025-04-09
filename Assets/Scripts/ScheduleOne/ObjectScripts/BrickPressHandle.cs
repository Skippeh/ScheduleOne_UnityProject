using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	public class BrickPressHandle : MonoBehaviour
	{
		private float lastClickPosition;

		[Header("Settings")]
		public float MoveSpeed;

		public bool Locked;

		[Header("References")]
		public Transform PlaneNormal;

		public Transform RaisedTransform;

		public Transform LoweredTransform;

		public Clickable HandleClickable;

		public AudioSourceController ClickSound;

		private Vector3 clickOffset;

		private bool isMoving;

		public bool Interactable { get; private set; }

		public float CurrentPosition { get; private set; }

		public float TargetPosition { get; private set; }

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void Move()
		{
		}

		private void UpdateSound(float difference)
		{
		}

		public void SetPosition(float position)
		{
		}

		public void SetInteractable(bool e)
		{
		}

		public void ClickStart(RaycastHit hit)
		{
		}

		public void ClickEnd()
		{
		}

		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}
	}
}
