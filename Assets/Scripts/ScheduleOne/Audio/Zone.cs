using System;
using UnityEngine;

namespace ScheduleOne.Audio
{
	public class Zone : MonoBehaviour
	{
		public const float UPDATE_INTERVAL = 0.25f;

		public Transform PointContainer;

		public bool IsClosed;

		public float VerticalSize;

		[Header("Debug")]
		public Color ZoneColor;

		private Vector3[] points;

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

		private Vector3[] GetPoints()
		{
			return null;
		}

		private bool DoBoundsContainPoint(Vector3 point)
		{
			return false;
		}

		private Tuple<Vector3, Vector3> GetBoundingPoints()
		{
			return null;
		}

		private bool IsPointInsidePolygon(Vector3[] polyPoints, Vector3 point)
		{
			return false;
		}

		private int CalculateWindingNumber(Vector2[] polygon, Vector2 point)
		{
			return 0;
		}

		private Vector3 GetClosestPointOnPolygon(Vector3[] polyPoints, Vector3 point)
		{
			return default(Vector3);
		}
	}
}
