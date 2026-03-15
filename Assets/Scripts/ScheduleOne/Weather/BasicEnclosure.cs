namespace ScheduleOne.Weather
{
	public class BasicEnclosure : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector3 _center;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector3 _size;

		[global::UnityEngine.SerializeField]
		private bool _isBlendZone;

		[global::UnityEngine.Header("Debug")]
		[global::UnityEngine.SerializeField]
		private float _backRadius;

		[global::UnityEngine.SerializeField]
		private float _frontRadius;

		[global::UnityEngine.SerializeField]
		private bool _debugMode;

		private global::UnityEngine.Vector3 _debugClosestPoint;

		private global::UnityEngine.Vector3 _debugOppositePoint;

		private float _debugBlendValue;

		private float _debugActiveRadius;

		public global::UnityEngine.Vector3 StartPoint => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 EndPoint => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 Size => default(global::UnityEngine.Vector3);

		public bool IsBlendZone => false;

		public bool WithinEnclosure(global::UnityEngine.Vector3 targetPosition)
		{
			return false;
		}

		public float GetEnclosureBlend(global::UnityEngine.Vector3 targetPosition)
		{
			return 0f;
		}

		public global::UnityEngine.Vector3 GetClosestPointOnZFaces(global::UnityEngine.Vector3 targetPosition)
		{
			return default(global::UnityEngine.Vector3);
		}

		public global::UnityEngine.Vector3 GetOppositeFacePoint(global::UnityEngine.Vector3 surfacePoint)
		{
			return default(global::UnityEngine.Vector3);
		}
	}
}
