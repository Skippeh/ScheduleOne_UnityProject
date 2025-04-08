namespace ScheduleOne.ObjectScripts
{
	public class BrickPressHandle : global::UnityEngine.MonoBehaviour
	{
		private float lastClickPosition;

		[global::UnityEngine.Header("Settings")]
		public float MoveSpeed;

		public bool Locked;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform PlaneNormal;

		public global::UnityEngine.Transform RaisedTransform;

		public global::UnityEngine.Transform LoweredTransform;

		public global::ScheduleOne.PlayerTasks.Clickable HandleClickable;

		public global::ScheduleOne.Audio.AudioSourceController ClickSound;

		private global::UnityEngine.Vector3 clickOffset;

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

		public void ClickStart(global::UnityEngine.RaycastHit hit)
		{
		}

		public void ClickEnd()
		{
		}

		private global::UnityEngine.Vector3 GetPlaneHit()
		{
			return default(global::UnityEngine.Vector3);
		}
	}
}
