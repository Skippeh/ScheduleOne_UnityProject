namespace ScheduleOne.Audio
{
	public class Zone : global::UnityEngine.MonoBehaviour
	{
		public const float UPDATE_INTERVAL = 0.25f;

		public global::UnityEngine.Transform PointContainer;

		public bool IsClosed;

		public float VerticalSize;

		[global::UnityEngine.Header("Debug")]
		public global::UnityEngine.Color ZoneColor;

		protected global::UnityEngine.Vector3[] points;

		protected virtual void Awake()
		{
		}

		private void OnDrawGizmos()
		{
		}

		protected global::UnityEngine.Vector3[] GetPoints()
		{
			return null;
		}

		protected bool DoBoundsContainPoint(global::UnityEngine.Vector3 point)
		{
			return false;
		}

		protected global::System.Tuple<global::UnityEngine.Vector3, global::UnityEngine.Vector3> GetBoundingPoints()
		{
			return null;
		}

		public bool IsPointInsidePolygon(global::UnityEngine.Vector3 point)
		{
			return false;
		}

		protected int CalculateWindingNumber(global::UnityEngine.Vector2[] polygon, global::UnityEngine.Vector2 point)
		{
			return 0;
		}

		protected global::UnityEngine.Vector3 GetClosestPointOnPolygon(global::UnityEngine.Vector3[] polyPoints, global::UnityEngine.Vector3 point)
		{
			return default(global::UnityEngine.Vector3);
		}
	}
}
