namespace ScheduleOne.Building
{
	public class Surface : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable
	{
		public enum ESurfaceType
		{
			Wall = 0,
			Roof = 1
		}

		public enum EFace
		{
			Front = 0,
			Back = 1,
			Top = 2,
			Bottom = 3,
			Left = 4,
			Right = 5
		}

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.Building.Surface.ESurfaceType SurfaceType;

		public global::System.Collections.Generic.List<global::ScheduleOne.Building.Surface.EFace> ValidFaces;

		public global::ScheduleOne.Property.Property ParentProperty;

		[global::UnityEngine.SerializeField]
		protected string BakedGUID;

		public global::System.Guid GUID { get; protected set; }

		public global::UnityEngine.Transform Container => null;

		[global::EasyButtons.Button]
		public void RegenerateGUID()
		{
		}

		private void OnValidate()
		{
		}

		private void OnDrawGizmos()
		{
		}

		protected virtual void Awake()
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		public global::UnityEngine.Vector3 GetRelativePosition(global::UnityEngine.Vector3 worldPosition)
		{
			return default(global::UnityEngine.Vector3);
		}

		public global::UnityEngine.Quaternion GetRelativeRotation(global::UnityEngine.Quaternion worldRotation)
		{
			return default(global::UnityEngine.Quaternion);
		}

		public bool IsFrontFace(global::UnityEngine.Vector3 point, global::UnityEngine.Collider collider)
		{
			return false;
		}

		public bool IsPointValid(global::UnityEngine.Vector3 point, global::UnityEngine.Collider hitCollider)
		{
			return false;
		}
	}
}
