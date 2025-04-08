namespace VLB
{
	public class PolygonHelper : global::UnityEngine.MonoBehaviour
	{
		public struct Plane2D
		{
			public global::UnityEngine.Vector2 normal;

			public float distance;

			public float Distance(global::UnityEngine.Vector2 point)
			{
				return 0f;
			}

			public global::UnityEngine.Vector2 ClosestPoint(global::UnityEngine.Vector2 pt)
			{
				return default(global::UnityEngine.Vector2);
			}

			public global::UnityEngine.Vector2 Intersect(global::UnityEngine.Vector2 p1, global::UnityEngine.Vector2 p2)
			{
				return default(global::UnityEngine.Vector2);
			}

			public bool GetSide(global::UnityEngine.Vector2 point)
			{
				return false;
			}

			public static global::VLB.PolygonHelper.Plane2D FromPoints(global::UnityEngine.Vector3 p1, global::UnityEngine.Vector3 p2)
			{
				return default(global::VLB.PolygonHelper.Plane2D);
			}

			public static global::VLB.PolygonHelper.Plane2D FromNormalAndPoint(global::UnityEngine.Vector3 normalizedNormal, global::UnityEngine.Vector3 p1)
			{
				return default(global::VLB.PolygonHelper.Plane2D);
			}

			public void Flip()
			{
			}

			public global::UnityEngine.Vector2[] CutConvex(global::UnityEngine.Vector2[] poly)
			{
				return null;
			}

			public override string ToString()
			{
				return null;
			}
		}
	}
}
