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

		private global::UnityEngine.Vector3[] points;

		public float LocalPlayerDistance { get; protected set; }

		private void Awake()
		{
		}

		public void Recalculate()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private global::UnityEngine.Vector3[] GetPoints()
		{
			return null;
		}

		private bool DoBoundsContainPoint(global::UnityEngine.Vector3 point)
		{
			return false;
		}

		private global::System.Tuple<global::UnityEngine.Vector3, global::UnityEngine.Vector3> GetBoundingPoints()
		{
			return null;
		}

		private bool IsPointInsidePolygon(global::UnityEngine.Vector3[] polyPoints, global::UnityEngine.Vector3 point)
		{
			return false;
		}

		private int CalculateWindingNumber(global::UnityEngine.Vector2[] polygon, global::UnityEngine.Vector2 point)
		{
			return 0;
		}

		private global::UnityEngine.Vector3 GetClosestPointOnPolygon(global::UnityEngine.Vector3[] polyPoints, global::UnityEngine.Vector3 point)
		{
			return default(global::UnityEngine.Vector3);
		}
	}
}
