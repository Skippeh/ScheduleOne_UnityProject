namespace VLB
{
	public static class Utils
	{
		public enum FloatPackingPrecision
		{
			High = 64,
			Low = 8,
			Undef = 0
		}

		private const float kEpsilon = 1E-05f;

		private static global::VLB.Utils.FloatPackingPrecision ms_FloatPackingPrecision;

		private const int kFloatPackingHighMinShaderLevel = 35;

		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return 0f;
		}

		public static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd)
		{
			return 0f;
		}

		public static void Swap<T>(ref T a, ref T b)
		{
		}

		public static string GetPath(global::UnityEngine.Transform current)
		{
			return null;
		}

		public static T NewWithComponent<T>(string name) where T : global::UnityEngine.Component
		{
			return null;
		}

		public static T GetOrAddComponent<T>(this global::UnityEngine.GameObject self) where T : global::UnityEngine.Component
		{
			return null;
		}

		public static T GetOrAddComponent<T>(this global::UnityEngine.MonoBehaviour self) where T : global::UnityEngine.Component
		{
			return null;
		}

		public static void ForeachComponentsInAnyChildrenOnly<T>(this global::UnityEngine.GameObject self, global::System.Action<T> lambda, bool includeInactive = false) where T : global::UnityEngine.Component
		{
		}

		public static void ForeachComponentsInDirectChildrenOnly<T>(this global::UnityEngine.GameObject self, global::System.Action<T> lambda, bool includeInactive = false) where T : global::UnityEngine.Component
		{
		}

		public static void SetupDepthCamera(global::UnityEngine.Camera depthCamera, float coneApexOffsetZ, float maxGeometryDistance, float coneRadiusStart, float coneRadiusEnd, global::UnityEngine.Vector3 beamLocalForward, global::UnityEngine.Vector3 lossyScale, bool isScalable, global::UnityEngine.Quaternion beamInternalLocalRotation, bool shouldScaleMinNearClipPlane)
		{
		}

		public static bool HasFlag(this global::System.Enum mask, global::System.Enum flags)
		{
			return false;
		}

		public static global::UnityEngine.Vector3 Divide(this global::UnityEngine.Vector3 aVector, global::UnityEngine.Vector3 scale)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector2 xy(this global::UnityEngine.Vector3 aVector)
		{
			return default(global::UnityEngine.Vector2);
		}

		public static global::UnityEngine.Vector2 xz(this global::UnityEngine.Vector3 aVector)
		{
			return default(global::UnityEngine.Vector2);
		}

		public static global::UnityEngine.Vector2 yz(this global::UnityEngine.Vector3 aVector)
		{
			return default(global::UnityEngine.Vector2);
		}

		public static global::UnityEngine.Vector2 yx(this global::UnityEngine.Vector3 aVector)
		{
			return default(global::UnityEngine.Vector2);
		}

		public static global::UnityEngine.Vector2 zx(this global::UnityEngine.Vector3 aVector)
		{
			return default(global::UnityEngine.Vector2);
		}

		public static global::UnityEngine.Vector2 zy(this global::UnityEngine.Vector3 aVector)
		{
			return default(global::UnityEngine.Vector2);
		}

		public static bool Approximately(this float a, float b, float epsilon = 1E-05f)
		{
			return false;
		}

		public static bool Approximately(this global::UnityEngine.Vector2 a, global::UnityEngine.Vector2 b, float epsilon = 1E-05f)
		{
			return false;
		}

		public static bool Approximately(this global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, float epsilon = 1E-05f)
		{
			return false;
		}

		public static bool Approximately(this global::UnityEngine.Vector4 a, global::UnityEngine.Vector4 b, float epsilon = 1E-05f)
		{
			return false;
		}

		public static global::UnityEngine.Vector4 AsVector4(this global::UnityEngine.Vector3 vec3, float w)
		{
			return default(global::UnityEngine.Vector4);
		}

		public static global::UnityEngine.Vector4 PlaneEquation(global::UnityEngine.Vector3 normalizedNormal, global::UnityEngine.Vector3 pt)
		{
			return default(global::UnityEngine.Vector4);
		}

		public static float GetVolumeCubic(this global::UnityEngine.Bounds self)
		{
			return 0f;
		}

		public static float GetMaxArea2D(this global::UnityEngine.Bounds self)
		{
			return 0f;
		}

		public static global::UnityEngine.Color Opaque(this global::UnityEngine.Color self)
		{
			return default(global::UnityEngine.Color);
		}

		public static global::UnityEngine.Color ComputeComplementaryColor(this global::UnityEngine.Color self, bool blackAndWhite)
		{
			return default(global::UnityEngine.Color);
		}

		public static global::UnityEngine.Plane TranslateCustom(this global::UnityEngine.Plane plane, global::UnityEngine.Vector3 translation)
		{
			return default(global::UnityEngine.Plane);
		}

		public static global::UnityEngine.Vector3 ClosestPointOnPlaneCustom(this global::UnityEngine.Plane plane, global::UnityEngine.Vector3 point)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static bool IsAlmostZero(float f)
		{
			return false;
		}

		public static bool IsValid(this global::UnityEngine.Plane plane)
		{
			return false;
		}

		public static void SetKeywordEnabled(this global::UnityEngine.Material mat, string name, bool enabled)
		{
		}

		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		public static global::UnityEngine.Matrix4x4 SampleInMatrix(this global::UnityEngine.Gradient self, int floatPackingPrecision)
		{
			return default(global::UnityEngine.Matrix4x4);
		}

		public static global::UnityEngine.Color[] SampleInArray(this global::UnityEngine.Gradient self, int samplesCount)
		{
			return null;
		}

		private static global::UnityEngine.Vector4 Vector4_Floor(global::UnityEngine.Vector4 vec)
		{
			return default(global::UnityEngine.Vector4);
		}

		public static float PackToFloat(this global::UnityEngine.Color color, int floatPackingPrecision)
		{
			return 0f;
		}

		public static global::VLB.Utils.FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(global::VLB.Utils.FloatPackingPrecision);
		}

		public static bool HasAtLeastOneFlag(this global::System.Enum mask, global::System.Enum flags)
		{
			return false;
		}

		public static void MarkCurrentSceneDirty()
		{
		}

		public static void MarkObjectDirty(global::UnityEngine.Object obj)
		{
		}
	}
}
