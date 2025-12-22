[global::Unity.Burst.BurstCompile]
public static class BurstFunctions
{
	public delegate void Average_0000004B_0024PostfixBurstDelegate(ref global::Unity.Collections.NativeArray<float> arr, out float result);

	internal static class Average_0000004B_0024BurstDirectCall
	{
		private static global::System.IntPtr Pointer;

		private static global::System.IntPtr DeferredCompilation;

		[global::Unity.Burst.BurstDiscard]
		private static void GetFunctionPointerDiscard(ref global::System.IntPtr P_0)
		{
		}

		private static global::System.IntPtr GetFunctionPointer()
		{
			return (global::System.IntPtr)0;
		}

		public static void Constructor()
		{
		}

		public static void Initialize()
		{
		}

		public static void Invoke(ref global::Unity.Collections.NativeArray<float> arr, out float result)
		{
			result = default(float);
		}
	}

	public delegate void Average_0000004C_0024PostfixBurstDelegate(ref global::Unity.Collections.NativeArray<global::UnityEngine.Vector3> arr, out global::UnityEngine.Vector3 result);

	internal static class Average_0000004C_0024BurstDirectCall
	{
		private static global::System.IntPtr Pointer;

		private static global::System.IntPtr DeferredCompilation;

		[global::Unity.Burst.BurstDiscard]
		private static void GetFunctionPointerDiscard(ref global::System.IntPtr P_0)
		{
		}

		private static global::System.IntPtr GetFunctionPointer()
		{
			return (global::System.IntPtr)0;
		}

		public static void Constructor()
		{
		}

		public static void Initialize()
		{
		}

		public static void Invoke(ref global::Unity.Collections.NativeArray<global::UnityEngine.Vector3> arr, out global::UnityEngine.Vector3 result)
		{
			result = default(global::UnityEngine.Vector3);
		}
	}

	[global::Unity.Burst.BurstCompile]
	public static void Average(ref global::Unity.Collections.NativeArray<float> arr, out float result)
	{
		result = default(float);
	}

	[global::Unity.Burst.BurstCompile]
	public static void Average(ref global::Unity.Collections.NativeArray<global::UnityEngine.Vector3> arr, out global::UnityEngine.Vector3 result)
	{
		result = default(global::UnityEngine.Vector3);
	}

	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
	[global::Unity.Burst.BurstCompile]
	public static void Average_0024BurstManaged(ref global::Unity.Collections.NativeArray<float> arr, out float result)
	{
		result = default(float);
	}

	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
	[global::Unity.Burst.BurstCompile]
	public static void Average_0024BurstManaged(ref global::Unity.Collections.NativeArray<global::UnityEngine.Vector3> arr, out global::UnityEngine.Vector3 result)
	{
		result = default(global::UnityEngine.Vector3);
	}
}
