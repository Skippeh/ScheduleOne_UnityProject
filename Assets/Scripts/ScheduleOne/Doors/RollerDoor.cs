namespace ScheduleOne.Doors
{
	public class RollerDoor : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Transform Door;

		public global::UnityEngine.Vector3 LocalPos_Open;

		public global::UnityEngine.Vector3 LocalPos_Closed;

		public float LerpTime;

		public global::UnityEngine.GameObject Blocker;

		private global::UnityEngine.Vector3 startPos;

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
