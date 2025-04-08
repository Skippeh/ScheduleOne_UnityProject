namespace ScheduleOne.ObjectScripts
{
	public class LabStand : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public float MoveSpeed;

		public bool FunnelEnabled;

		public float FunnelThreshold;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Animation Anim;

		public global::UnityEngine.Transform GripTransform;

		public global::UnityEngine.Transform SpinnyThingy;

		public global::UnityEngine.Transform RaisedTransform;

		public global::UnityEngine.Transform LoweredTransform;

		public global::UnityEngine.Transform PlaneNormal;

		public global::ScheduleOne.PlayerTasks.Clickable HandleClickable;

		public global::UnityEngine.Transform Funnel;

		public global::UnityEngine.GameObject Highlight;

		public global::ScheduleOne.Audio.AudioSourceController LowerSound;

		public global::ScheduleOne.Audio.AudioSourceController RaiseSound;

		private global::UnityEngine.Vector3 clickOffset;

		private bool isMoving;

		public bool Interactable { get; private set; }

		public float CurrentPosition { get; private set; }

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

		private global::UnityEngine.Vector3 GetPlaneHit()
		{
			return default(global::UnityEngine.Vector3);
		}

		public void ClickEnd()
		{
		}
	}
}
