namespace ScheduleOne.Tools
{
	public class CopyTransform : global::UnityEngine.MonoBehaviour
	{
		public enum EUpdateMode
		{
			Update = 0,
			LateUpdate = 1,
			FixedUpdate = 2
		}

		public global::UnityEngine.Transform Target;

		public global::ScheduleOne.Tools.CopyTransform.EUpdateMode UpdateMode;

		public bool CopyPosition;

		public bool CopyRotation;

		public bool CopyScale;

		public global::UnityEngine.Vector3 GlobalPositionOffset;

		public global::UnityEngine.Vector3 LocalPositionOffset;

		public global::UnityEngine.Vector3 RotationOffset;

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void Copy()
		{
		}
	}
}
