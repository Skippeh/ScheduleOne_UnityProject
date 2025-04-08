namespace ScheduleOne.DevUtilities
{
	public class SetTransform : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Frequency Settings")]
		public bool SetOnAwake;

		public bool SetOnUpdate;

		public bool SetOnLateUpdate;

		[global::UnityEngine.Header("Transform Settings")]
		public bool SetPosition;

		public global::UnityEngine.Vector3 LocalPosition;

		public bool SetRotation;

		public global::UnityEngine.Vector3 LocalRotation;

		public bool SetScale;

		public global::UnityEngine.Vector3 LocalScale;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void Set()
		{
		}
	}
}
