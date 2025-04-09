using UnityEngine;

namespace VLB
{
	public static class MeshGenerator
	{
		public enum CapMode
		{
			None = 0,
			OneVertexPerCap_1Cap = 1,
			OneVertexPerCap_2Caps = 2,
			SpecificVerticesPerCap_1Cap = 3,
			SpecificVerticesPerCap_2Caps = 4
		}

		private const float kMinTruncatedRadius = 0.001f;

		private static float GetAngleOffset(int numSides)
		{
			return 0f;
		}

		private static float GetRadiiScale(int numSides)
		{
			return 0f;
		}

		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		public static Mesh GenerateConeZ_Radii(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		public static Mesh GenerateConeZ_Radii_DoubleCaps(float lengthZ, float radiusStart, float radiusEnd, int numSides, bool inverted)
		{
			return null;
		}

		public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			return default(Bounds);
		}

		private static int GetCapAdditionalVerticesCount(CapMode capMode, int numSides)
		{
			return 0;
		}

		private static int GetCapAdditionalIndicesCount(CapMode capMode, int numSides)
		{
			return 0;
		}

		public static int GetVertexCount(int numSides, int numSegments, CapMode capMode, bool doubleSided)
		{
			return 0;
		}

		public static int GetIndicesCount(int numSides, int numSegments, CapMode capMode, bool doubleSided)
		{
			return 0;
		}

		public static int GetSharedMeshVertexCount()
		{
			return 0;
		}

		public static int GetSharedMeshIndicesCount()
		{
			return 0;
		}

		public static int GetSharedMeshHDVertexCount()
		{
			return 0;
		}

		public static int GetSharedMeshHDIndicesCount()
		{
			return 0;
		}
	}
}
