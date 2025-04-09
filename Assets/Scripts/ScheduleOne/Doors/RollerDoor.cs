using UnityEngine;

namespace ScheduleOne.Doors
{
	public class RollerDoor : MonoBehaviour
	{
		[Header("Settings")]
		public Transform Door;

		public Vector3 LocalPos_Open;

		public Vector3 LocalPos_Closed;

		public float LerpTime;

		public GameObject Blocker;

		private Vector3 startPos;

		private float timeSinceValueChange;

		public bool IsOpen { get; protected set; }

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		protected virtual bool CanOpen()
		{
			return false;
		}
	}
}
